using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class UpdateData
    {
        public static void Test()
        {
            MySqlConnection conn = new MySqlConnection("Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP");
            MySqlCommand cmd = new MySqlCommand("UPDATE PART SET UNIT_ID = 6 WHERE ID = 3", conn);
           
            conn.Open();
            
            int i = cmd.ExecuteNonQuery();
            
            conn.Close();
            Console.WriteLine(" Record(s) {0} successfully updated", i);
        }
    }
}