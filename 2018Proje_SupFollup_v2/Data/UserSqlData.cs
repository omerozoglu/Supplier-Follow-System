using _2018Proje_SupFollup_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _2018Proje_SupFollup_v2.Data
{
    public class UserSqlData
    {
        private IUser user;
        private static SqlConnection conn = connection;
        private string TABLE_NAME = "table_üye";

        public UserSqlData(IUser u)
        {
            this.user = u;
        }

        public mUser GetUser(List<string> columns, List<string> values)
        {
            try
            {
                mUser t_user = setparams(columns, values);
                return t_user;
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("GetUser @::=>> " + e.Data + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public List<mUser> GetAllUser()
        {
            try
            {
                List<mUser> t_users = new List<mUser>();
                SqlCommand comm = command;
                conn.Open();
                comm.CommandText = "SELECT * FROM " + TABLE_NAME;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    mUser m = new mUser();
                    m.Id = int.Parse(reader["id"].ToString());
                    m.Ad = reader["ad"].ToString();
                    m.Kad = reader["kad"].ToString();
                    m.Eposta = reader["eposta"].ToString();
                    m.Sifre = reader["sifre"].ToString();
                    m.Yetki = int.Parse(reader["yetki"].ToString());
                    t_users.Add(m);
                }
                reader.Close();
                return t_users;
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("GetAllHata @::=>> ", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public bool InsertUser()
        {
            try
            {
                SqlCommand comm = command;
                conn.Open();
                comm.CommandText = "INSERT INTO " + TABLE_NAME + " (ad,kad,sifre,eposta) VALUES (@0,@1,@2,@3)";
                comm.Parameters.AddWithValue("@0", user.Ad);
                comm.Parameters.AddWithValue("@1", user.Kad);
                comm.Parameters.AddWithValue("@2", user.Sifre);
                comm.Parameters.AddWithValue("@3", user.Eposta);
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("InsertUser @::=>> ", e.Source);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public void UpdateUser(object o)
        {
            try
            {
                SqlCommand comm = command;
                conn.Open();
                comm.CommandText = "UPDATE " + TABLE_NAME + " SET ad=@0,sifre=@1,eposta=@2,yetki=@3 WHERE id=@4";
                comm.Parameters.AddWithValue("@0", user.Ad);
                comm.Parameters.AddWithValue("@1", user.Sifre);
                comm.Parameters.AddWithValue("@2", user.Eposta);
                comm.Parameters.AddWithValue("@3", user.Yetki);
                comm.Parameters.AddWithValue("@4", user.Id);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("UpdateUser @::=>> ", e.Source);
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteUser(object o)
        {
            try
            {
                SqlCommand comm = command;
                conn.Open();
                comm.CommandText = "DELETE " + TABLE_NAME + " WHERE id=@0";
                comm.Parameters.AddWithValue("@0", user.Id);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("DeleteUser @::=>> ", e.Source);
            }
            finally
            {
                conn.Close();
            }
        }
        public List<mUser> SearchUser()
        {
            try
            {
                List<mUser> t_users = new List<mUser>();
                SqlCommand comm = command;
                conn.Open();
                comm.CommandText = "select * from table_üye " +
                                    "WHERE ad like '%"+ user.Ad + "%' or kad like '%" + user.Kad +"%'"+
                                    " order by ad ,kad";
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    mUser m = new mUser();
                    m.Id = int.Parse(reader["id"].ToString());
                    m.Ad = reader["ad"].ToString();
                    m.Kad = reader["kad"].ToString();
                    m.Eposta = reader["eposta"].ToString();
                    m.Sifre = reader["sifre"].ToString();
                    m.Yetki = int.Parse(reader["yetki"].ToString());
                    t_users.Add(m);
                }
                reader.Close();
                return t_users;
            }
            catch (Exception e)
            {
                global::System.Windows.Forms.MessageBox.Show("SearchUser @::=>> ", e.Source);
            }
            finally
            {
                conn.Close();
            }return null;
        }

        private static SqlConnection connection
        {
            get
            {
                return new SqlConnection("Data Source =.; " +
                "Initial Catalog=TKDB;" +
                "Integrated Security = True;");
            }
        }
        private static SqlCommand command
        {
            get
            {
                return new SqlCommand() { Connection = conn };
            }
        }

        private mUser setparams(List<string> columns, List<string> values)
        {
            conn.Open();
            mUser t_user = new mUser();
            SqlCommand comm = command;
            comm.CommandText = "SELECT * FROM " + TABLE_NAME + " WHERE ";
            for (int i = 0; i < columns.Count; i++)
            {
                if (columns.Count == 1 || i == columns.Count - 1)
                {
                    comm.CommandText += " " + columns[i].ToString() + "=@" + columns[i].ToString();
                }
                else
                {
                    comm.CommandText += " " + columns[i].ToString() + "=@" + columns[i].ToString() + " and ";
                }

            }
            for (int i = 0; i < columns.Count; i++)
            {
                comm.Parameters.AddWithValue("@" + columns[i].ToString(), values[i].ToString());
            }
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                //isteğimiz kolonu istediğimiz modelin  propertisine atamıyoruz
                t_user.Id = int.Parse(reader["id"].ToString());
                t_user.Ad = reader["ad"].ToString();
                t_user.Kad = reader["kad"].ToString();
                t_user.Sifre = reader["sifre"].ToString();
                t_user.Eposta = reader["eposta"].ToString();
                t_user.Yetki = int.Parse(reader["yetki"].ToString());
                t_user.IsLoginedUser = true;
            }
            reader.Close();
            conn.Close();
            return t_user;
        }
    }
}
