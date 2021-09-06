using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDAL
    {
        public List<Student> GetAllStudents()
        {
            var connStr = "server=.;database=ta;integrated security=SSPI";
            using var connection = new SqlConnection(connStr);

            var sql = "select id, name, homecity, telephone, state from students";
            var command = new SqlCommand(sql, connection);

            connection.Open(); // 保证开启

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
    }
}
