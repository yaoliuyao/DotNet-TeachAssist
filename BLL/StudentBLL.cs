using DAL;
using Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL studentDAL = new StudentDAL();

        public List<Student> GetAllStudent()
        {
            // 记录日志...
            return studentDAL.GetStudents();
        }

        public List<Student> GetPresentStudents()
        {
            // 记录日志...
            return studentDAL.GetStudents(1);
        }

        public List<Student> GetAbsentStudents()
        {
            // 记录日志...
            return studentDAL.GetStudents(2);
        }

        public int SaveUpdate(Student student)
        {
            return studentDAL.UpdateStudent(student);
        }

        public int SaveAdd(Student student)
        {
            if (studentDAL.GetStudentById(student.Id) != null)
            {
                throw new Exception($"这个学生已经存在，不能重复添加: {student.Id}");
            }
            return studentDAL.AddStudent(student);
        }
    }
}
