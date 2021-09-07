using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL
    {
        public List<Student> GetStudents(int state = -1)
        {
            using var connection = DbHelper.GetConnection();

            var sql = "select id, name, homecity, telephone, state from students";

            var command = new SqlCommand() { Connection = connection };

            if (state == -1)
            {
                command.CommandText = sql;
            }
            else
            {
                command.CommandText = sql + " where state=@state";
                command.Parameters.AddWithValue("@state", state);
            }

            using var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4]
                });
            }
            return students;
        }

        public List<Student> SearchStudents(string condition)
        {
            using var connection = DbHelper.GetConnection();

            var sql = @"select id, name, homecity, telephone, state from students
                        where name like @name or homecity like @hc";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", $"%{condition}%");
            command.Parameters.AddWithValue("@hc", $"%{condition}%");

            using var reader = command.ExecuteReader();
            var students = new List<Student>();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4]
                });
            }
            return students;
        }

        public Student GetStudentById(string id)
        {
            using var connection = DbHelper.GetConnection();

            var sql = @"select id, name, homecity, telephone, state from students where id=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Student()
                {
                    Id = reader[0] as string,
                    Name = reader["name"] as string,
                    Homecity = reader[2] as string,
                    Telephone = reader[3] as string,
                    State = (int)reader[4]
                };
            }
            return null;
        }

        public int AddStudent(Student student)
        {
            return DbHelper.DoExecuteNonQuery(
                @"insert into students (id, name, homecity, telephone) values (@id, @name, @hc, @tel)",
                new SqlParameter("@id", student.Id ),
                new SqlParameter("@name", student.Name),
                new SqlParameter("@hc", student.Homecity),
                new SqlParameter("@tel", student.Telephone)
            );
        }

        public int UpdateStudent(Student student)
        {
            return DbHelper.DoExecuteNonQuery(
                @"update students set homecity=@hc, telephone=@tel, state=@state where id=@id",
                new SqlParameter("id", student.Id),
                new SqlParameter("hc", student.Homecity),
                new SqlParameter("tel", student.Telephone),
                new SqlParameter("state", student.State)
            );
        }

        public int DeleteStudent(string id)
        {
            return DbHelper.DoExecuteNonQuery(
                @"delete students where id=@id",
                new SqlParameter("id", id)
            );
        }
    }
}
