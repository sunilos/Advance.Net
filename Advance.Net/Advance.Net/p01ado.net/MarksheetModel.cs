using MySql.Data.MySqlClient;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Advance.Net.p01ado.net
{
    public class MarksheetModel
    {
        private const string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;"; 
        private MySqlConnection conn = new MySqlConnection(cs);

        /**
         * Update a record in the database.
         */
        public void Update(Marksheet marksheet)
        {
            string sql = "update marksheet set rollNo = @rollno where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("rollno", marksheet.RollNo));
            cm.Parameters.Add(new MySqlParameter("id", marksheet.Id));
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
        public void Delete(Marksheet marksheet)
        {
            string sql = "delete from marksheet where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", marksheet.Id));
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
         * Add a record in the database.
         */
        public void Add(Marksheet marksheet)
        {
            string sql = "INSERT INTO MARKSHEET values (@id,@rollno,@fname,@lname,@physics,@chemistry,@maths)";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", marksheet.Id));
            cm.Parameters.Add(new MySqlParameter("rollno", marksheet.RollNo));
            cm.Parameters.Add(new MySqlParameter("fname", marksheet.FName));
            cm.Parameters.Add(new MySqlParameter("lname", marksheet.LName));
            cm.Parameters.Add(new MySqlParameter("physics", marksheet.Physics));
            cm.Parameters.Add(new MySqlParameter("chemistry", marksheet.Chemistry));
            cm.Parameters.Add(new MySqlParameter("maths", marksheet.Maths));
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
        public IList Search()
        {
            Marksheet marksheet = new Marksheet();
            string sql = "Select * from marksheet";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["rollno"] + " " + sdr["fname"] + " " + sdr["lname"] + sdr["physics"] + " " + sdr["chemistry"] + " " + sdr["maths"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                conn.Close();
            return (IList)marksheet;
        }
        public Marksheet FindById(int id)
        {
            Marksheet marksheet = new Marksheet();
            string sql = "Select * from marksheet where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", marksheet.Id));
            try
            {
                MySqlDataReader sdr = cm.ExecuteReader(); 
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["rollno"] + " " + sdr["fname"] + " " + sdr["lname"] + sdr["physics"] + " " + sdr["chemistry"] + " " + sdr["maths"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                conn.Close();
            return marksheet;
        }
    }
}
