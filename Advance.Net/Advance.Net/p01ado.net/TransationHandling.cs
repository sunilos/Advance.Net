using Microsoft.AspNetCore.DataProtection;
using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class TransationHandling
    {
        public static void RunTransaction(string myConnString)
        {
            MySqlConnection conn = new MySqlConnection(myConnString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            // Start a local transaction
            MySqlTransaction tx = conn.BeginTransaction();
            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
           

            try
            {
                cmd.CommandText = "insert into part VALUES (10, 'Marker', 'Blue', 10)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into part VALUES (11, 'Pins', 'Red', 11)";
                cmd.ExecuteNonQuery();
                tx.Commit();
                Console.WriteLine("Both records are written to database.");
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