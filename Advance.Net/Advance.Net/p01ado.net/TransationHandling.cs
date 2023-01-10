using Microsoft.AspNetCore.DataProtection;
using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class TransationHandling
    {
        /*public static void Test()
        {
            string connString = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP";
            MySqlConnection conn = new MySqlConnection(connString);
            
            conn.Open(); //Open a connection befole Begin Transaction
            
            MySqlTransaction trn = conn.BeginTransaction(); //Trn Start
            MySqlCommand cmd = new MySqlCommand("INSERT INTO PART VALUES(6, 'Pen', 'Yellow', 6)", conn, trn);
            
            int i = cmd.ExecuteNonQuery();
            
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO PART VALUES(7,'SCREW', 'SILVER', 7)", conn, trn);
            i = cmd1.ExecuteNonQuery();
            
            trn.Commit(); //trn.Rollback();
            conn.Close();

            Console.WriteLine("Transation Handled");*/


        public static void RunTransaction(string myConnString)
        {
            MySqlConnection myConnection = new MySqlConnection(myConnString);
            myConnection.Open();

            MySqlCommand myCommand = myConnection.CreateCommand();
            MySqlTransaction myTrans;

            // Start a local transaction
            myTrans = myConnection.BeginTransaction();
            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            myCommand.Connection = myConnection;
            myCommand.Transaction = myTrans;

            try
            {
                myCommand.CommandText = "insert into part VALUES (8, 'Lipstick', 'pink', 8)";
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = "insert into part VALUES (9, 'Bluetooth', 'Levander', 9)";
                myCommand.ExecuteNonQuery();
                myTrans.Commit();
                Console.WriteLine("Both records are written to database.");
            }
            catch (Exception e)
            {
                try
                {
                    myTrans.Rollback();
                }
                catch (MySqlException ex)
                {
                    if (myTrans.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                        " was encountered while attempting to roll back the transaction.");
                    }
                }

                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}