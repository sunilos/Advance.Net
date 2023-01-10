using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class MarksheetModel
    {
        private static const String cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;"; 
        /**
         * Update a record in the database.
         */

        private MySqlConnection conn = null;
        
        public MarksheetModel(){
              MySqlConnection conn = new MySqlConnection(cs);
        }
        
        public void Update(MarksheetBean bean)
        {
            String sql = "update marksheet set rollNo = @rn where id = @id";
            conn.Open();
            MySqlCommand cm = new MySqlCommand(sql, conn);
            cm.Parameters.Add(new SQlParameters( "rn","RN01"));
            
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                cm.ExecuteNonQuery(); // record is updated 
            }
            catch (Exception e)
            {
                tx.Rollback();
            }
            conn.Close();
        }
        /**
         * Delete a record in the database.
         */
        public void Delete(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cm = new MySqlCommand("delete from marksheet where id = '?'", conn);
            MySqlTransaction tx = conn.BeginTransaction();

            try
            {
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {

                tx.Rollback();

                if (tx.Connection != null)
                {
                    Console.WriteLine("An exception of type " +
                    " was encountered while attempting to roll back the transaction.");
                }


                Console.WriteLine("An exception of type " + e.GetType() +
                            " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                conn.Close();
            }
        }
        /**
         * Add a record in the database.
         */
        public void Add(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cm = new MySqlCommand("INSERT INTO MARKSHEET (id,rollno,fname,lname,physics,chemistry,maths) VALUES(" + bean.getId() + ",'" + bean.getRollNo() + "','" + bean.getFName() + "','" + bean.getLName() + "'," + bean.getPhysics() + "," + bean.getChemistry() + "," + bean.getMaths() + ")", conn);
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {

                tx.Rollback();

                if (tx.Connection != null)
                {
                    Console.WriteLine("An exception of type " +
                    " was encountered while attempting to roll back the transaction.");
                }


                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                conn.Close();
            }
        }
        /**
         * Display a record in the database.
         */
        public void Display(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cm = new MySqlCommand("Select * from marksheet", conn);
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                MySqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    // Displaying Record  
                    Console.WriteLine(sdr["id"] + " " + sdr["fname"] + " " + sdr["lname"]);
                }

                Console.WriteLine("Record Display Successfully");
            }
            catch (Exception e)
            {

                tx.Rollback();

                if (tx.Connection != null)
                {
                    Console.WriteLine("An exception of type " +
                    " was encountered while attempting to roll back the transaction.");
                }


                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
