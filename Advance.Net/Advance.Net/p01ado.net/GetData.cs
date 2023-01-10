using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Advance.Net.p01ado.net
{
    public class GetData
    {
        public static void Test()
        {
            MySqlConnection conn = new MySqlConnection("Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM part", conn);
            
            conn.Open();
            
            MySqlDataReader reader = cmd.ExecuteReader(); // Execute Query
            Console.WriteLine("ID\tName\tColor\tUnit ID");
            
            while (reader.Read())
            {
                Console.Write(reader.GetInt32(0));
                Console.Write("\t" + reader.GetString(1));
                Console.Write("\t" + reader.GetString(2));
                Console.WriteLine("\t" + reader.GetInt32(3));
            }
            
            reader.Close();
            conn.Close();
        }
    }
}