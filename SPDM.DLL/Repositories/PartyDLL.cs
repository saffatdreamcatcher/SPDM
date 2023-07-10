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
    public class PartyDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public PartyDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public PartyDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from Party where Id = " + id.ToString();
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

        public List<Party> GetAll(string whereClause = "")
        {
            var parties = new List<Party>();
            
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
                comm.CommandText = "Select * from Party" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        Party party = new Party(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            party.UpdateTime = null;
                        }
                        else
                        {
                            party.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        party.Account = reader["Account"].ToString();
                        party.Name = reader["Name"].ToString();
                        party.Address = reader["Address"].ToString();
                        party.City = reader["City"].ToString();
                        party.PostalCode = reader["PostalCode"].ToString();
                        party.Country = reader["Country"].ToString();
                        party.PhoneNo = reader["PhoneNo"] is DBNull ? null : reader["PhoneNo"].ToString();
                        party.MobileNo = reader["MobileNo"].ToString();
                        party.Fax = reader["Fax"] is DBNull ? null : reader["Fax"].ToString();
                        party.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                        party.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        parties.Add(party);
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
            return parties;
        }

        public Party GetById(int id)
        {
            Party party = new Party();
            

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from Party where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        party = new Party(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            party.UpdateTime = null;
                        }
                        else
                        {
                            party.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        party.Account = reader["Account"].ToString();
                        party.Name = reader["Name"].ToString();
                        party.Address = reader["Address"].ToString();
                        party.City = reader["City"].ToString();
                        party.PostalCode = reader["PostalCode"].ToString();
                        party.Country = reader["Country"].ToString();
                        party.PhoneNo = reader["PhoneNo"] is DBNull ? null : reader["PhoneNo"].ToString();
                        party.MobileNo = reader["MobileNo"].ToString();
                        party.Fax = reader["Fax"] is DBNull ? null : reader["Fax"].ToString();
                        party.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                        party.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();

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
            return party;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Party party = new Party();
            

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
                comm.CommandText = "Select count(*) from Party " + whereClause;
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


        public int Save(Party party)
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

                if (party.IsNew)
                {
                    comm.CommandText = "INSERT INTO Party(CreateTime, Name, Account, Address, City, PostalCode, Country, PhoneNo, MobileNo, Fax, Email, Note) VALUES(@CreateTime, @Name, @Account, @Address, @City, @PostalCode, @Country, @PhoneNo, @MobileNo, @Fax, @Email, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Party SET Name = @Name, Account = @Account, Address = @Address, City = @City, PostalCode= @PostalCode, Country= @Country, PhoneNo =@PhoneNo, MobileNo = @MobileNo, Fax = @Fax, Email = @Email, Note = @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = party.Id;
                }
                comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = party.Name;
                comm.Parameters.Add("@Account", SqlDbType.VarChar).Value = party.Account;
                comm.Parameters.Add("@Address", SqlDbType.VarChar).Value = party.Address;
                comm.Parameters.Add("@Country", SqlDbType.VarChar).Value = party.Country;
                comm.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = party.PostalCode;
                comm.Parameters.Add("@City", SqlDbType.VarChar).Value = party.City;
                comm.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = party.PhoneNo;
                comm.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = party.MobileNo;
                comm.Parameters.Add("@Fax", SqlDbType.VarChar).Value = party.Fax;
                comm.Parameters.Add("@Email", SqlDbType.VarChar).Value = party.Email;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = party.Note;
                if (party.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    party.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = party.Id;
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
