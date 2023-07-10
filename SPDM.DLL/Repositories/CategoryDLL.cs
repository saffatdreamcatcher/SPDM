using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Repositories
{
    public class CategoryDLL
    {

        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public CategoryDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public CategoryDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from Category where Id = " + id.ToString();
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

        public List<Category> GetAll(string whereClause = "")
        {
            List<Category> categories = new List<Category>();
           
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
                comm.CommandText = "Select * from Category " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        Category category = new Category(id, createTime); 
                        category.Name = reader["Name"].ToString();
                        category.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        category.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];
                        categories.Add(category);
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
            return categories;
        }

        public Category GetById(int id)
        {
            Category categories = new Category();
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandText = "Select * from Category where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        categories = new Category(id, createTime);
                        categories.Name = reader["Name"].ToString();
                        categories.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        categories.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];

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
            return categories;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Category categories = new Category();
            
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
                comm.CommandText = "Select count(*) from Category " + whereClause;
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

        /// <summary>
        /// Save The Category 
        /// </summary>
        /// <param name="categories"> Category To Save </param>
        /// <returns> Generated Primary key in Insert </returns>
        public int Save(Category categories)
        {
            int primaryKey = 0;
            //string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
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



                if (categories.IsNew)
                {
                    comm.CommandText = "INSERT INTO Category(CreateTime, Name, Description, Photo) VALUES(@CreateTime, @Name, @Description, @Photo); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Category SET Name = @Name, Description = @Description, Photo = @Photo WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = categories.Id;
                }
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = categories.Name;
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = categories.Description;
                if (categories.Photo == null)
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = categories.Photo;
                }
                if (categories.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    categories.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = categories.Id;
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

        
    }
}