using DAL;
using Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL
    {
        public List<Student> GetAllNormalStudents()
        {
            var dal = new StudentDAL();
            var students = dal.GetAllStudents().Where(s => s.State == 1);

            Console.WriteLine("hhahaha");

            return students.ToList();
        }
    }
}
