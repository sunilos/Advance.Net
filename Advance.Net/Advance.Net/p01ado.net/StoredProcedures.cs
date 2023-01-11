using MySql.Data.MySqlClient;
using System.Data;

namespace Advance.Net.p01ado.net
{
    public class StoredProcedures
    {
        public static void Test(string name, string city, string address)
        {
            String cs = "Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP";

            MySqlConnection conn = new MySqlConnection(cs);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("AddNewEmpDetails", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Address", address);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}