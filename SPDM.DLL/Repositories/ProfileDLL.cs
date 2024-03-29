﻿using SPDM.DLL.Entities;
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
    public class ProfileDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public ProfileDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public ProfileDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from Profile where Id = " + id.ToString();
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

        public List<Profile> GetAll(string whereClause = "")
        {
            var profiles = new List<Profile>();
            
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

                comm.CommandText = "Select * from Profile " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        
                        Profile profile = new Profile(id, createTime);
                        profile.Name = reader["Name"].ToString();
                        profile.UserId = Convert.ToInt32(reader["UserId"]);
                        profile.Address = reader["Address"].ToString();
                        profile.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                        profile.Designation = reader["Designation"].ToString();
                        profile.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                        profile.MobileNo = reader["MobileNo"].ToString();
                        profile.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];
                        profiles.Add(profile);
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
            return profiles;
        }

        public Profile GetById(int id)
        {
            Profile profile = new Profile();
            

            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from Profile where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        profile.Id = Convert.ToInt32(reader["id"]);
                        profile.Name = reader["Name"].ToString();
                        profile.UserId = Convert.ToInt32(reader["UserId"]);
                        profile.Address = reader["Address"].ToString();
                        profile.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                        profile.Designation = reader["Designation"].ToString();
                        profile.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                        profile.MobileNo = reader["MobileNo"].ToString();
                        profile.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];


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
            return profile;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Profile profile = new Profile();
            

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
                comm.CommandText = "Select count(*) from Profile " + whereClause;
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

        public int Save(Profile profile)
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

                if (profile.IsNew)
                {
                    comm.CommandText = "INSERT INTO Profile(CreateTime, UserId, Name, Address, Email, Designation, Phone, " +
                        "MobileNo, Photo) VALUES(@CreateTime, @UserId, @Name, @Address, @Email, @Designation, @Phone," +
                        " @MobileNo, @Photo); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    comm.CommandText = "Update Profile SET  UserId = @UserId, Name= @Name," +
                        " Address = @Address, Email = @Email, Designation = @Designation, Phone= @Phone, MobileNo= @MobileNo, " +
                        "Photo = @Photo WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = profile.Id;
                    
                }
                comm.Parameters.Add("@UserId", SqlDbType.Int).Value = profile.UserId;
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = profile.Name;
                comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = profile.Address;
                comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = profile.Email;
                comm.Parameters.Add("@Designation", SqlDbType.VarChar).Value = profile.Designation;
                comm.Parameters.Add("@Phone", SqlDbType.VarChar).Value = profile.Phone;
                comm.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = profile.MobileNo;
                if (profile.Photo == null)
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = profile.Photo;
                }


                if (profile.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    profile.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = profile.Id;
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

        public Profile GetByUserId(int userId)
        {
            Profile profile = new Profile();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Profile where UserId = " + userId;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                       
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        profile.Id = Convert.ToInt32(reader["id"]);
                        profile.Name = reader["Name"].ToString();
                        profile.UserId = Convert.ToInt32(reader["UserId"]);
                        profile.Address = reader["Address"].ToString();
                        profile.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                        profile.Designation = reader["Designation"] is DBNull ? null : reader["Designation"].ToString();
                        profile.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                        profile.MobileNo = reader["MobileNo"].ToString();
                        profile.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];


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
            return profile;

        }

    }
}
