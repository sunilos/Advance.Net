using MySql.Data.MySqlClient;
using System.Data;

namespace Advance.Net.p01ado.net
{
    public class TestDataSet
    {
        private const string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;"; //connection string

        public static void Test()
        {
            MySqlConnection conn = new MySqlConnection(cs);  //creates connection

            string sql = "Select id,name,color,unit_id FROM part";  //selects fields to be accessed

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = cmd;

            DataSet ds = new DataSet();  //creates data set

            conn.Open();   // opens connection

            Console.WriteLine("Retrieving rows from the test table");

            string part = "part";
            dataAdapter.Fill(ds, part);

            DataTable dt = ds.Tables[part];  //i get an error here

            foreach (DataRow dr in dt.Rows)  //iterates over rows in table
            {

                Console.WriteLine("id" + dr[("id")]);  // i had to comment out this region because also get an error, but this is not my doubt right now
                Console.WriteLine("name" + dr[("name")]);
                Console.WriteLine("color" + dr[("color")]);
                Console.WriteLine("unit_id" + dr[("unit_id")]);
            }

            conn.Close();  //close connection
        }
    }
}