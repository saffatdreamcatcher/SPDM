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
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public UserDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public UserDLL(SqlTransaction sqlTrans)
        {

            if (sqlTrans == null)
            {
                throw new ArgumentNullException("SqlTransaction is required");
            }
            if (sqlTrans.Connection == null)
            {
                throw new ArgumentNullException("SqlConnection is required in Transaction");
            }
            this.sqlConnection = sqlTrans.Connection;
            this.sqlTransaction = sqlTrans;
            isEnableTransaction = true;

        }
        public int Delete(int id)
        {
            int noOfRowAffected = 0;
           
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Delete from [User] where Id = " + id.ToString();
                noOfRowAffected = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return noOfRowAffected;

        }

        public int MarkAsInactive(int id)
        {
            int noOfRowAffected = 0;

            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                //comm.CommandText = "Update [User] SET IsActive = 0 WHERE Id= " + id.ToString();
                comm.CommandText = "Update [User] SET IsActive = 0 WHERE Id=@hozoborolo";
                comm.Parameters.Add("@hozoborolo", SqlDbType.Int).Value = id;

                noOfRowAffected = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return noOfRowAffected;

        }

        public List<User> GetAll(string whereClause = "")
        {
            var users = new List<User>();
            
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from [User] Where IsActive = 1 " + whereClause;
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
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return users;
        }

        public User GetById(int id)
        {
            User user = new User();
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from [User] where id = " + id + " and IsActive = 1";
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        user = new User(id, createTime);
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

                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return user;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var user = new User();
            

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select count(*) from [User] Where IsActive = 1" + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return count;
        }


        public int Save(User user)
        {
            int primaryKey = 0;
            //var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            //SqlConnection conn = new SqlConnection();
            try
            {
                //conn.ConnectionString = myConnectionString;
                //conn.Open();

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

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
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
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
                        "WHERE  UserName = @UserName and Password = @Password and IsActive = 1";

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

        public User GetByName(string name)
        {
            User user = new User();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from [User] where UserName = '" + name + "'";
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        user = new User(id, createTime);
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

        public void ChangePassword(int userid, string password)
        {
            
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE [User] SET Password = @Password WHERE Id = @Id ";
                comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                comm.Parameters.Add("@Id", SqlDbType.VarChar).Value = userid;
                comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
        }

    }
}
