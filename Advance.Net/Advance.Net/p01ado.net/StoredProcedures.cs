using MySql.Data.MySqlClient;
using System.Data;

namespace Advance.Net.p01ado.net
{
    public class StoredProcedures
    {
        public static void Test(string name, string city, string address)
        {
            String cs = "Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP";

            MySqlConnection conn = null;

            using (conn = new MySqlConnection(cs))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("AddNewEmpDetails", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.AddWithValue("@City", SqlDbType.NVarChar).Value = city;
                cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = address;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}