using BLL;
using DAL;
using Models;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dal = new StudentDAL();
            dal.DeleteStudent("helloksdk22222");

            var students = dal.GetStudents();

      

            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
