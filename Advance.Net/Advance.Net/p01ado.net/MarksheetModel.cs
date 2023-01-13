using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using System.Collections;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.Common;
using System.Data;

namespace Advance.Net.p01ado.net
{
    public class MarksheetModel
    {
        private const string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";  // MySqlConnection
        //private const string cs = @"Data Source=localhost;Initial Catalog=raystech;User ID=root;Password=root;port=3307";  // MS SqlConnection 

        private MySqlConnection conn = new MySqlConnection(cs);

        /**
         * Update a record in the database.
         */
        public void update(Marksheet m)
        {
            string sql = "update marksheet set rollNo = @rollno, fName = @fname, lName = @lname, Physics = @physics, Chemistry = @chemistry, Maths = @maths where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("rollno", m.RollNo));
            cm.Parameters.Add(new MySqlParameter("fname", m.FName));
            cm.Parameters.Add(new MySqlParameter("lname", m.LName));
            cm.Parameters.Add(new MySqlParameter("physics", m.Physics));
            cm.Parameters.Add(new MySqlParameter("chemistry", m.Chemistry));
            cm.Parameters.Add(new MySqlParameter("maths", m.Maths));
            cm.Parameters.Add(new MySqlParameter("id", m.Id));
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                cm.ExecuteNonQuery();
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
            }
                conn.Close();
        }

        /**
         * Delete a record in the database.
         */
        public void delete(Marksheet m)
        {
            string sql = "delete from marksheet where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", m.Id));
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                cm.ExecuteNonQuery();
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
            }
                conn.Close();
        }

        /**
	     * Used to primarykey for database communication
	     */
        public int nextPK()
        {

            int pk = 0;
            string sql = "select max(ID) from MARKSHEET";
            MySqlCommand cm = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader rs = cm.ExecuteReader();
                while (rs.Read())
                {
                    pk = rs.GetInt32(0);
                }
                rs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pk + 1;
        }

        /**
         * Add a record in the database.
         */
        public void add(Marksheet m)
        {
            string sql = "INSERT INTO MARKSHEET values (@id,@rollno,@fname,@lname,@physics,@chemistry,@maths)";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);

            cm.Parameters.Add(new MySqlParameter("id", nextPK()));
            cm.Parameters.Add(new MySqlParameter("rollno", m.RollNo));
            cm.Parameters.Add(new MySqlParameter("fname", m.FName));
            cm.Parameters.Add(new MySqlParameter("lname", m.LName));
            cm.Parameters.Add(new MySqlParameter("physics", m.Physics));
            cm.Parameters.Add(new MySqlParameter("chemistry", m.Chemistry));
            cm.Parameters.Add(new MySqlParameter("maths", m.Maths));
            MySqlTransaction tx = conn.BeginTransaction(); 
            try
            {
                cm.ExecuteNonQuery();
                tx.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                tx.Rollback();
            }
                conn.Close();
        }

        /**
         * Display a record in the database.
         */
        public IList search()
        {
            Marksheet m = new Marksheet();
            string sql = "Select * from marksheet";
            conn.Open();

            MySqlCommand cm = new MySqlCommand(sql, conn);
             ArrayList list = new ArrayList();
            try
            {
                MySqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    m.Id = sdr.GetInt32(0);
                    m.RollNo = sdr.GetString(1);
                    m.FName = sdr.GetString(2);
                    m.LName = sdr.GetString(3);
                    m.Physics = sdr.GetInt32(4);
                    m.Chemistry = sdr.GetInt32(5);
                    m.Maths = sdr.GetInt32(6);

                    list.Add(m);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                conn.Close();
            return list;
        }

        /**
	     * Used to find record in database by Primarykey
	     */
        public Marksheet findById(long id)
        {
            Marksheet m = new Marksheet();
            string sql = "Select * from marksheet where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", id));
            try
            {
                cm.ExecuteNonQuery();
                MySqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    
                    m.Id = sdr.GetInt32(0);
                    m.RollNo = sdr.GetString(1);
                    m.FName = sdr.GetString(2);
                    m.LName = sdr.GetString(3);
                    m.Physics = sdr.GetInt32(4);
                    m.Chemistry = sdr.GetInt32(5);
                    m.Maths = sdr.GetInt32(6);
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Query Not Execute");
            }
            conn.Close();
            return m;
        }
    }
}