using _2018Proje_SupFollup_v2.Models;
using System.Data.SqlClient;
using _2018Proje_SupFollup_v2.DataHelper;
using System;
using System.Collections.Generic;

namespace _2018Proje_SupFollup_v2.Data
{
    public class SupplierSystemSqlData
    {
        private ISupplierSystem m;
        private SqlConnection conn;
        private SqlCommand comm;

        private SupplierSystemSqlData() { }
        public SupplierSystemSqlData(ISupplierSystem m)
        {
            this.m = m;
            SqlDataHelper.TableName = "table_m_temp";
            SqlDataHelper.DataSource = ".";
            SqlDataHelper.DatabaseName = "TKDB";
            SqlDataHelper.IntegratedSecurity = true;
            conn = SqlDataHelper.GetSqlConnection();
            comm =new SqlCommand();
            comm.Connection = conn;
        }

        public List<SupplierSystemModel> getAllSuppSystm()
        {
            try
            {
                List<SupplierSystemModel> tlst = new List<SupplierSystemModel>();
                comm.Connection.Open();
                //ınnser joın olacaks
                comm.CommandText = "SELECT * FROM "+SqlDataHelper.TableName;
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    SupplierSystemModel t = new SupplierSystemModel();
                    t.id = reader["id"];
                    t.name = reader["isinadi"];
                    t.startdate= reader["bsltrh"];
                    t.enddate = reader["btstrh"];
                    t.piece = reader["isadt"];
                    t.properties= reader["özlkler"];
                    t.personid= reader["isksid"];
                    t.suppid = reader["tdrkciid"];
                    t.isinvoice = reader["faturaksldmi"];
                    t.agncyprice = reader["ajnsfiyat"];
                    t.price = reader["fiyat"];
                    t.logid = reader["üyelogid"];
                    tlst.Add(t);
                }
                reader.Close();
                return tlst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comm.Connection.Close();
            }
            return null;
        }
        public SupplierSystemModel getSuppSystm()
        {
            try
            {
                SupplierSystemModel t = new SupplierSystemModel();
                comm.Connection.Open();
                //ınnser joın olacaks
                comm.CommandText = "SELECT * FROM " + SqlDataHelper.TableName+"WHERE id=@id";
                comm.Parameters.AddWithValue("@id", m.id);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    t.id = reader["id"];
                    t.name = reader["isinadi"];
                    t.startdate = reader["bsltrh"];
                    t.enddate = reader["btstrh"];
                    t.piece = reader["isadt"];
                    t.properties = reader["özlkler"];
                    t.personid = reader["isksid"];
                    t.suppid = reader["tdrkciid"];
                    t.isinvoice = reader["faturaksldmi"];
                    t.agncyprice = reader["ajnsfiyat"];
                    t.price = reader["fiyat"];
                    t.logid = reader["üyelogid"];
                }
                reader.Close();
                return t;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comm.Connection.Close();
            }
            return null;
        }
        public List<SupplierSystemModel> searchSuppSystm()
        {
            try
            {
                List<SupplierSystemModel> tlst = new List<SupplierSystemModel>();
                comm.Connection.Open();
                //ınnser joın olacaks
                comm.CommandText = "SELECT * FROM " + SqlDataHelper.TableName + "WHERE isinadi like '%" + m.name + "%'" +
                    " order by isinadi ";
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    SupplierSystemModel t = new SupplierSystemModel();
                    t.id = reader["id"];
                    t.name = reader["isinadi"];
                    t.startdate = reader["bsltrh"];
                    t.enddate = reader["btstrh"];
                    t.piece = reader["isadt"];
                    t.properties = reader["özlkler"];
                    t.personid = reader["isksid"];
                    t.suppid = reader["tdrkciid"];
                    t.isinvoice = reader["faturaksldmi"];
                    t.agncyprice = reader["ajnsfiyat"];
                    t.price = reader["fiyat"];
                    t.logid = reader["üyelogid"];
                    tlst.Add(t);
                }
                reader.Close();
                return tlst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comm.Connection.Close();
            }
            return null;
        }

        public void insert()
        {
            try
            {
                comm.Connection.Open();
                comm.CommandText = "INSERT INTO"+SqlDataHelper.TableName+ "(isinadi,bsltrh,btstrh ,isadt,özlkler,isksid,tdrkciid,faturaksldmi,ajnsfiyat,fiyat,üyelogid) VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)";
                comm.Parameters.AddWithValue("@0",m.name);
                comm.Parameters.AddWithValue("@1", (DateTime)m.startdate);
                comm.Parameters.AddWithValue("@2", (DateTime)m.enddate);
                comm.Parameters.AddWithValue("@3", (int)m.piece);
                comm.Parameters.AddWithValue("@4", m.properties);
                comm.Parameters.AddWithValue("@5", (int)m.personid);
                comm.Parameters.AddWithValue("@6", (int)m.suppid);
                comm.Parameters.AddWithValue("@7", (bool)m.isinvoice);
                comm.Parameters.AddWithValue("@8", (int)m.agncyprice);
                comm.Parameters.AddWithValue("@9", (int)m.price);
                comm.Parameters.AddWithValue("@10", (int)m.logid);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
     
            }
            finally
            {
                comm.Connection.Close();
            }
        }
        public void update()
        {
            try
            {
                comm.Connection.Open();
                comm.CommandText = "UPDATE " + SqlDataHelper.TableName + "SET isinadi=@0 , bsltrh=@1 , " +
                    "btstrh=@2 , isadt=@3 , özlkler=@4 , isksid=@5 , tdrkciid=@6 , faturaksldmi=@7 , ajnsfiyat=@8 ," +
                    "fiyat=@9 , üyelogid=@10 WHERE id=@id";
                comm.Parameters.AddWithValue("@id", (int)m.id);
                comm.Parameters.AddWithValue("@0", m.name);
                comm.Parameters.AddWithValue("@1", (DateTime)m.startdate);
                comm.Parameters.AddWithValue("@2", (DateTime)m.enddate);
                comm.Parameters.AddWithValue("@3", (int)m.piece);
                comm.Parameters.AddWithValue("@4", m.properties);
                comm.Parameters.AddWithValue("@5", (int)m.personid);
                comm.Parameters.AddWithValue("@6", (int)m.suppid);
                comm.Parameters.AddWithValue("@7", (bool)m.isinvoice);
                comm.Parameters.AddWithValue("@8", (int)m.agncyprice);
                comm.Parameters.AddWithValue("@9", (int)m.price);
                comm.Parameters.AddWithValue("@10", (int)m.logid);
                comm.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("basarılı");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("NOOOOOOOOO");
                throw ex;

            }
            finally
            {
                comm.Connection.Close();
            }
        }
        public void delete()
        {
            try
            {
                comm.Connection.Open();
                comm.CommandText = "DELETE"+SqlDataHelper.TableName+"WHERE id=@id";
                comm.Parameters.AddWithValue("@idd", (int)m.id);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comm.Connection.Close();
            }
        }

    }


}
