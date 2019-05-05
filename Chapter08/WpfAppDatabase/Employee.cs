using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace WpfAppDatabase
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string DatabasePath { get; set; }
        public Employee(string databasePath)
        {
            DatabasePath = databasePath;
        }
        public Employee()
        {
            DatabasePath = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\ERP.mdf;";
        }
        internal List<Employee> Get()
        {
            List<Employee> Employees = new List<Employee>();
            try
            {
                using (SqlConnection connection = new
                SqlConnection(DatabasePath))
                {
                    connection.Open();
                    string commandText = @"SELECT EmployeeId,
                    FirstName,LastName,DateOfBirth,Address,
                    Telephone,Cellphone,Email FROM Employees";
                    SqlCommand command = new
                        SqlCommand(commandText, connection);
                    SqlDataReader dataReader =
                        command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Employees.Add(
                            new Employee()
                            {
                                EmployeeId = dataReader.GetInt32(0),
                                FirstName = dataReader.GetString(1),
                                LastName = dataReader.GetString(2),
                                DateOfBirth = dataReader.GetDateTime(3),
                                Address = dataReader.GetString(4),
                                Telephone = dataReader.GetString(5),
                                Cellphone = dataReader.GetString(6),
                                Email = dataReader.GetString(7),
                            }
                        );
                    }
                }
            }

            catch (Exception)
            {

            }
            return Employees;
        }
        internal Employee Get(int employeeId)
        {
            Employee employee = null;
            if (employeeId != 0)
            {
                using (SqlConnection connection = new
                SqlConnection(DatabasePath))
                {
                    connection.Open();
                    string commandText = @"SELECT EmployeeId,
                    FirstName,LastName,DateOfBirth,Address,
                    Telephone,Cellphone,Email FROM Employees
                    WHERE EmployeeId=@EmployeeId";
                    SqlCommand command = new
                        SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    SqlDataReader dataReader =
                        command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        employee =
                            new Employee()
                            {
                                EmployeeId = dataReader.GetInt32(0),
                                FirstName = dataReader.GetString(1),
                                LastName = dataReader.GetString(2),
                                DateOfBirth = dataReader.GetDateTime(3),
                                Address = dataReader.GetString(4),
                                Telephone = dataReader.GetString(5),
                                Cellphone = dataReader.GetString(6),
                                Email = dataReader.GetString(7),
                            };

                    }
                }
            }
            return employee;
        }
        internal bool Delete (int employeeId)
        {
            bool isDeleted = false;
            if (employeeId != 0)
            {
                using (SqlConnection connection = new
                SqlConnection(DatabasePath))
                {
                    connection.Open();
                    string commandText = @"DELETE Employees
                    WHERE EmployeeId=@EmployeeId";
                    SqlCommand command = new
                        SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    isDeleted = command.ExecuteNonQuery() > 0;
                }
            }
            return isDeleted;
        }
        internal bool Update (Employee employee)
        {
            bool isUpdated = false;
            if (employee != null)
            {
                using (SqlConnection connection = new
                SqlConnection(DatabasePath))
                {
                    connection.Open();
                    string commandText = @"UPDATE Employees 
                    SET FirstName=@FirstName,
                    LastName=@LastName,
                    DateOfBirth=@DateOfBirth,
                    Address=@Address,
                    Telephone=@Telephone,
                    Cellphone=@Cellphone,
                    Email=@Email 
                    WHERE EmployeeId=@EmployeeId;";
                    SqlCommand command = new
                        SqlCommand(commandText, connection);
                     
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@Telephone", employee.Telephone);
                    command.Parameters.AddWithValue("@Cellphone", employee.Cellphone);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    isUpdated = command.ExecuteNonQuery()>0;

                }
            }
            return isUpdated;
        }
        internal bool Add (Employee employee)
        {
            bool isSaved = false;
            if (employee != null)
            {
                using (SqlConnection connection = new
                SqlConnection(DatabasePath))
                {
                    connection.Open();
                    string commandText = @"INSERT Employees( 
                    FirstName, LastName, DateOfBirth,
                    Address, Telephone, Cellphone, Email)
                    VALUES(@FirstName, @LastName, @DateOfBirth,
                    @Address, @Telephone,  @Cellphone, @Email);";
                    SqlCommand command = new
                        SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@Telephone", employee.Telephone);
                    command.Parameters.AddWithValue("@Cellphone", employee.Cellphone);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    isSaved = command.ExecuteNonQuery() > 0;

                }
            }
            return isSaved;
        }
    }
}
