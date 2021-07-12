using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfStudents.Common.Models;
using WcfStudents.Infrastructure.Repositories.Contracts;

namespace WcfStudents.Infrastructure.Repositories.Implementation.Product
{
    public class SqlProduct : IDataAccessProduct
    {
        private static readonly string connetionString;

        static SqlProduct()
        {
            connetionString = "Data Source=.,1434;Initial Catalog=StudentTable;User ID=sa;Password=<YourStrong@Passw0rd>";
        }
        public SqlProduct()
        {

        }

        public Student Add(Student student)
        {
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string query = $"INSERT INTO students (name, surname, age, birthday) " +
                    "VALUES (@name, @surname, @age, @birthday)";

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@name", student.Name);
                    command.Parameters.AddWithValue("@surname", student.Surname);
                    command.Parameters.AddWithValue("@age", student.Age);
                    command.Parameters.AddWithValue("@birthday", student.Birthday.ToString("yyyy-MM-dd"));

                    int id = Convert.ToInt32(command.ExecuteScalar());

                    student.StudentID = id;
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return student;
        }

        public Student DeleteById(int id)
        {
            Student student = new Student();

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string query = $"DELETE FROM students WHERE id = @id";

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@id", id);

                    int rows = command.ExecuteNonQuery();

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string query = $"SELECT * FROM students";

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand(query, cnn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string idstudent = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        string age = reader["age"].ToString();
                        string birthday = reader["birthday"].ToString();

                        Student student = new Student(int.Parse(idstudent), name, surname, int.Parse(age), DateTime.Parse(birthday));
                        list.Add(student);
                    }

                    //student.StudentID = id;
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return list;
        }

        public Student GetById(int id)
        {
            Student student = new Student();

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string query = $"SELECT * FROM students WHERE id = @id";

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string idstudent = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        string age = reader["age"].ToString();
                        string birthday = reader["birthday"].ToString();

                        student = new Student(int.Parse(idstudent), name, surname, int.Parse(age), DateTime.Parse(birthday));
                    }

                    //student.StudentID = id;
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return student;
        }

        public Student Update(Student student)
        {

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string query = $"UPDATE students SET name = @name, surname = @surname, age = @age, birthday = @birthday " +
                    "WHERE id = @id";

                try
                {
                    cnn.Open();

                    SqlCommand command = new SqlCommand(query, cnn);

                    command.Parameters.AddWithValue("@name", student.Name);
                    command.Parameters.AddWithValue("@surname", student.Surname);
                    command.Parameters.AddWithValue("@age", student.Age);
                    command.Parameters.AddWithValue("@birthday", student.Birthday.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@id", student.StudentID);

                    int rows = command.ExecuteNonQuery();

                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return student;
        }
    }
}
