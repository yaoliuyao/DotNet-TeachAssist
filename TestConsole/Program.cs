using BLL;
using DAL;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var bll = new StudentBLL();
            foreach(var student in bll.GetAllNormalStudents())
            {
                Console.WriteLine(student);
            }
        }
    }
}
