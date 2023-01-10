using MySql.Data.MySqlClient;

namespace Advance.Net.p01ado.net
{
    public class MarksheetModel
    {
        /**
         * Update a record in the database.
         */

        public void Update(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("update marksheet set rollNo = '?' where id = '?'", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Updated Successfully");
            conn.Close();
        }

        /**
         * Delete a record in the database.
         */
        public void Delete(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("delete from marksheet where id = '?'", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Deleted Successfully");
            conn.Close();
        }

        /**
         * Add a record in the database.
         */
        public void Add(MarksheetBean bean)
        {
            string cs = @"Host=localhost;database=raystech;Userid=root;Password=root;port=3307;protocol=TCP;";

            MySqlConnection conn = new MySqlConnection(cs);

            MySqlCommand cm = new MySqlCommand("INSERT INTO MARKSHEET (id,rollno,fname,lname,physics,chemistry,maths) VALUES("+bean.getId()+",'"+bean.getRollNo() + "','" + bean.getFName() + "','" + bean.getLName() + "'," + bean.getPhysics() + "," + bean.getChemistry() + "," + bean.getMaths()+")", conn);

            conn.Open();

            cm.ExecuteNonQuery();
            // Displaying a message  
            Console.WriteLine("Record Inserted Successfully");
            conn.Close();
        }

        /**
         * Display a record in the database.
         */
        public void Display(MarksheetBean bean)
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