using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    /** 
    * apppy CRUD operationsat MySQL database.
    */
    public class CrudOparetion
    {
        /**
         * Create a table in the database.
         */
        public void Create()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("create table marksheet(id int(255) not null primary key, name varchar(255), color varchar(255), unit_id int(255) default NULL)", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Table created Successfully");
            conn.Close();
        }

        /**
         * Update a record in the database.
         */

        public void Update()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("update marksheet set rollNo = 'ab2002' where id = '102'", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Updated Successfully");
            conn.Close();
        }

        /**
         * Delete a record in the database.
         */
        public void Delete()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("delete from marksheet where id = '1'", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Deleted Successfully");
            conn.Close();
        }

        /**
         * Add a record in the database.
         */
        public void Add()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("insert into marksheet (id, rollNo, fname, lname, phy, che, mat)" +
                " values ('104', 'ab2004', 'Rohan', 'Sahu', '45', '12', '02')", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Inserted Successfully");
            conn.Close();
        }

        /**
         * Display a record in the database.
         */
        public void Display()
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("Select * from marksheet", conn);

            conn.Open();

            MySqlDataReader sdr = cm.ExecuteReader();
            // Iterating Data  
            while (sdr.Read())
            {
                // Displaying Record  
                Console.WriteLine(sdr["id"] + " " + sdr["fname"] + " " + sdr["lname"]);
            }

            Console.WriteLine("Record Display Successfully");
            conn.Close();
        }
    }
}