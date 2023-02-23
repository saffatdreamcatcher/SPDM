﻿using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Repositories
{
    public class ItemDLL
    {
        private string photoFilePath;

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
                comm.CommandText = "Delete from Item where Id = " + id.ToString();
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


        public List<Item> GetAll(string whereClause = "")
        {
            var items = new List<Item>();
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
                comm.CommandText = "Select * from Item" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);

                        Item item = new Item(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            item.UpdateTime = null;
                        }
                        else
                        {
                            item.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        item.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        item.Number = Convert.ToInt32(reader["Number"]);
                        item.Name = reader["Name"].ToString();
                        item.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        item.Unit = Convert.ToInt32(reader["Unit"]);

                        if (reader["VatRate"] is DBNull)
                        {
                            item.VatRate = null;
                        }
                        else
                        {
                            item.VatRate = Convert.ToDouble(reader["VatRate"]);
                        }
                        item.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];
                        item.IsBlocked = Convert.ToBoolean(reader["IsBlocked"].ToString());
                        items.Add(item);
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
            return items;
        }
        
        public Item GetById(int id)
        {
            Item item = new Item();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Item where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        item  = new Item(id, createTime);
                        item.Number = Convert.ToInt32(reader["Number"].ToString());
                        item.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        item.Name = reader["Name"].ToString();
                        item.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                        item.Unit = Convert.ToInt32(reader["Unit"]);

                        if (reader["VatRate"] is DBNull)
                        {
                            item.VatRate = null;
                        }
                        else
                        {
                            item.VatRate = Convert.ToDouble(reader["VatRate"]);
                        }
                        
                        item.IsBlocked = Convert.ToBoolean(reader["IsBlocked"].ToString());
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
            return item;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Item item = new Item();
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
                comm.CommandText = "Select count(*) from Item " + whereClause;
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

        public int Save(Item item)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (item.IsNew)
                {
                    comm.CommandText = "INSERT INTO Item(CreateTime, UpdateTime, Name, CategoryId, Number, Description, Unit, Price, VatRate, Photo, IsBlocked) VALUES(@CreateTime, @UpdateTime, @Name, @CategoryId, @Number, @Description, @Unit, @Price, @VatRate, @Photo, @IsBlocked); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DBNull.Value;
                }
                else
                {
                    comm.CommandText = "Update Item SET Name = @Name, CategoryId = @CategoryId, Number = @Number, Description = @Description, Unit= @Unit, Price= @Price, VatRate =@VatRate, Photo = @Photo, IsBlocked = @IsBlocked WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = item.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                
                comm.Parameters.Add("@CategoryId", SqlDbType.VarChar).Value = item.CategoryId;
                comm.Parameters.Add("@Number", SqlDbType.VarChar).Value = item.Number;
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = item.Name;
                comm.Parameters.Add("@Description", SqlDbType.VarChar).Value = item.Description;
                comm.Parameters.Add("@Unit", SqlDbType.VarChar).Value = item.Unit;
                comm.Parameters.Add("@Price", SqlDbType.VarChar).Value = item.Price;
                comm.Parameters.Add("@VatRate", SqlDbType.VarChar).Value = item.VatRate;
                if (item.Photo == null)
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("@Photo", SqlDbType.Image).Value = item.Photo;
                }
                
                comm.Parameters.Add("@IsBlocked", SqlDbType.VarChar).Value = item.IsBlocked;
                
                if (item.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    item.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = item.Id;
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

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;

        }
    }
}
