using MySql.Data.MySqlClient;
using System.Data;

namespace Advance.Net.p01ado.net
{
    public class TestDataSet
    {
        public static void Test()
        {
            string connectionString = "Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP"; //connection string

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);  //creates connection

            string selectString = "Select id,name,color,unit_id FROM part";  //selects fields to be accessed

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = selectString;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            mySqlDataAdapter.SelectCommand = mySqlCommand;

            DataSet test1DataSet = new DataSet();  //creates data set

            mySqlConnection.Open();   // opens connection

            Console.WriteLine("Retrieving rows from the test table");

            string dataTableName = "part";
            mySqlDataAdapter.Fill(test1DataSet, dataTableName);

            DataTable myDataTable = test1DataSet.Tables[dataTableName];  //i get an error here

            foreach (DataRow myDataRow in myDataTable.Rows)  //iterates over rows in table
            {

                /*Console.WriteLine("id") = + myDataRow[("id")];  // i had to comment out this region because also get an error, but this is not my doubt right now
                Console.WriteLine("name") = + myDataRow[("name")];
                Console.WriteLine("color") = + myDataRow[("color")];
                Console.WriteLine("unit_id") = +myDataRow[("unit_id")];*/
            }

            mySqlConnection.Close();  //close connection
        }
    }
}