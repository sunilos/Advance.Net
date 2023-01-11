using MySql.Data.MySqlClient;

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

        public void Update(Marksheet bean)
        {
            string sql = "update marksheet set rollNo = @rollno where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("rollno", "sk2002"));
            cm.Parameters.Add(new MySqlParameter("id", 2));
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Updated Successfully");
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        /**
         * Delete a record in the database.
         */
        public void Delete(Marksheet bean)
        {
            string sql = "delete from marksheet where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new MySqlParameter("id", 2));
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Deleted Successfully");
                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        /**
         * Add a record in the database.
         */
        public void Add(Marksheet bean)
        {
            string sql = "INSERT INTO MARKSHEET values (@id,@rollno,@fname,@lname,@physics,@chemistry,@maths)";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);

            cm.Parameters.Add(new MySqlParameter("id", 2));
            cm.Parameters.Add(new MySqlParameter("rollno", "sk02"));
            cm.Parameters.Add(new MySqlParameter("fname", "Vaibhav"));
            cm.Parameters.Add(new MySqlParameter("lname", "Gehlot"));
            cm.Parameters.Add(new MySqlParameter("physics", 78));
            cm.Parameters.Add(new MySqlParameter("chemistry", 65));
            cm.Parameters.Add(new MySqlParameter("maths", 92));
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
                tx.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                tx.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        /**
         * Display a record in the database.
         */
        public void Display(Marksheet bean)
        {
            string sql = "Select * from marksheet";
            conn.Open();
            
            MySqlCommand cm = new MySqlCommand(sql, conn);
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                MySqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    // Displaying Record  
                    Console.WriteLine(sdr["id"] + " " + sdr["rollno"] + " " + sdr["fname"] + " " + sdr["lname"] + sdr["physics"] + " " + sdr["chemistry"] + " " + sdr["maths"]);
                }
                Console.WriteLine("Record Display Successfully");
                tx.Commit();
            }
            catch (Exception e)
            {
                tx.Rollback();
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}