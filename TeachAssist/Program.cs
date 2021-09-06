using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;

namespace TeachAssist
{
    class Program
    {
        static void Main(string[] args)
        {
            var ta = new TeachAssist();
            ta.Start();
        }
    }

    class TeachAssist
    {
        public string Path { get; set; } = "E:\\aaa.txt";

        public void Start()
        {
            Menu();
            Dispatch();
        }

        public void Menu()
        {
            Console.Write(@"
==== 教学辅助 ====

1. 语音点名
2. 提问抽查
3. 设置名单路径 ({0})

请按相应数字进入相应功能。

PRESS KEY CONTINUE.
", Path);
        }

        public void Dispatch()
        {
            var key = Console.ReadKey().Key;
            Console.Clear();
            switch (key)
            {
                case ConsoleKey.D1:
                    new Rollcall().StartRoll(Path);
                    break;
                case ConsoleKey.D2:
                    new Quiz().StartQuiz(Path);
                    break;
                case ConsoleKey.D3:
                    Menu();
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }
    }

    class TeachBase
    {
        public string[] Names { get; set; }

        public void LoadNames(string file)
        {
            var r = new Random();
            Names = File.ReadAllLines(file)
                .Where(name => !string.IsNullOrEmpty(name) && name[0] != '-')
                .OrderBy(item => r.Next())
                .ToArray();
        }

        public void Speak(string content)
        {
            var speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(content);
        }
    }

    class Rollcall : TeachBase
    {
        public string[] Absents { get; set; } = {};

        public void StartRoll(string path)
        {
            LoadNames(path);
            RollNames();
            Report();
        }

        public void RollNames()
        {
            Console.Write("按任意键开始点名...");
            Console.Read();

            foreach (var name in Names)
            {
                while (true)
                {
                    Call(name);

                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.B)
                    {
                        string[] arr = new string[Absents.Length + 1];
                        for (var i = 0; i < Absents.Length; i++)
                        {
                            arr[i] = Absents[i];
                        }

                        arr[Absents.Length] = name;
                        Absents = arr;
                        break;
                    }
                    else if (key.Key == ConsoleKey.R)
                    {
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }
        }

        public void Call(string name)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(name);
            Console.ResetColor();
            Speak(name);
        }

        public void Report()
        {
            Console.WriteLine();
            Console.WriteLine($"总共有 {Names.Length} 人，未到的有 {Absents.Length} 人");
            Console.WriteLine();
            if (Absents.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("全都到啦!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("缺席的名单为:\n");
                Console.ResetColor();
                foreach (var n in Absents)
                {
                    Console.WriteLine($" - {n}");
                }
            }
        }
    }

    class Quiz : TeachBase
    {
        private Random _random = new Random();

        public string RandomName()
        {
            return Names[_random.Next(Names.Length - 1)];
        }

        public void StartQuiz(string path)
        {
            LoadNames(path);
            do {
                string name = RandomName();
                Console.WriteLine(name);
                Speak(name);
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
