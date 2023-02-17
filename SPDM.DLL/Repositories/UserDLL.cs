using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Repositories
{
    public class UserDLL
    {
        public int Delete(int id)
        {
            int noOfRowAffected = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Delete from User where Id = " + id.ToString();
                noOfRowAffected = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return noOfRowAffected;

        }

        public List<User> GetAll(string whereClause = "")
        {
            var users = new List<User>();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from [User] " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        User user = new User(id, createTime);
                        user.UserName = reader["UserName"].ToString();
                        user.Password = reader["Password"].ToString();

                        if (reader["LockoutEndDate"] is DBNull)
                        {
                            user.LockoutEndDate = null;
                        }
                        else
                        {
                            user.LockoutEndDate = Convert.ToDateTime(reader["LockoutEndDate"]);
                        }

                        user.LockoutEnabled = Convert.ToBoolean(reader["LockoutEnabled"]);
                        user.AccessFailedCount = Convert.ToInt32(reader["AccessFailedCount"]);
                        user.IsActive = Convert.ToBoolean(reader["IsActive"]);

                        users.Add(user);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return users;
        }

        public User GetById(int id)
        {
            User user = new User();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from User where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        user = new User(id, createTime);
                        user.UserName = reader["UserName"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.LockoutEndDate = Convert.ToDateTime(reader["LockoutEndDate"]);
                        user.LockoutEnabled = Convert.ToBoolean(reader["LockoutEnabled"]);
                        user.AccessFailedCount = Convert.ToInt32(reader["AccessFailedCount"]);
                        user.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return user;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var user = new User();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select count(*) from User " + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return count;
        }


        public int Save(User user)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (user.IsNew)
                {
                    comm.CommandText = "INSERT INTO [User](CreateTime, UserName, Password, LockoutEndDate," +
                        "LockoutEnabled, AccessFailedCount, IsActive) VALUES(@CreateTime, @UserName, @Password, " +
                        "@LockoutEndDate, @LockoutEnabled, @AccessFailedCount, @IsActive); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update [User] SET UserName = @UserName, Password = @Password, " +
                        "LockoutEndDate= @LockoutEndDate, LockoutEnabled = @LockoutEnabled, " +
                        "AccessFailedCount = @AccessFailedCount , IsActive = @IsActive WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                }
                comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user.UserName;
                comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
                comm.Parameters.Add("@LockoutEndDate", SqlDbType.VarChar).Value = DBNull.Value;
                comm.Parameters.Add("@LockoutEnabled", SqlDbType.Bit).Value = user.LockoutEnabled;
                comm.Parameters.Add("@AccessFailedCount", SqlDbType.VarChar).Value = user.AccessFailedCount;
                comm.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;
                if (user.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    user.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = user.Id;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return primaryKey;
        }

        public bool UserExist(string username, string password)
        {
            bool isUserExist = false;
           
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                comm.CommandText = "SELECT " +
                        "CASE WHEN COUNT( Id ) >= 1 THEN " +
                        "CAST( 1 as BIT ) " +
                        "ELSE " +
                        " CAST( 0 as BIT ) " +
                        "END As IsPresent " +
                        "FROM [dbo].[User] " +
                        "WHERE  UserName = @UserName and Password = @Password";

                comm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;
                comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                
                isUserExist = Convert.ToBoolean(comm.ExecuteScalar());
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
            return isUserExist;
        }

    }
}
