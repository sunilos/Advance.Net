using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class DDLStatements
    {
        public void Create()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("create table part(id int(255) not null primary key, name varchar(255), color varchar(255), unit_id int(255) default NULL)", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Table created Successfully");
            conn.Close();
        }
        public void Add()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("INSERT INTO part VALUES (3,'spoon','Blue',2)", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Inserted Successfully");
            conn.Close();
        }
        public void Update()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("UPDATE part SET color = 'black', unit_id = 3 WHERE id=2", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Updated Successfully");
            conn.Close();
        }
        public void Delete()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("DELETE FROM part WHERE id=4", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Deleted Successfully");
            conn.Close();
        }
        public void Display()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("Select * from part", conn);
            //MySqlCommand cm = new MySqlCommand("SELECT id, name, color FROM part", conn);
            //MySqlCommand cm = new MySqlCommand("SELECT * FROM part WHERE color = 'Green'", conn);
            //MySqlCommand cm = new MySqlCommand("SELECT * FROM part ORDER BY name", conn);

            conn.Open();

            MySqlDataReader sdr = cm.ExecuteReader();
            // Iterating Data  
            while (sdr.Read())
            {
                // Displaying Record  
                Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["color"]);
            }

            Console.WriteLine("Record Display Successfully");
            conn.Close();
        }
    }
}