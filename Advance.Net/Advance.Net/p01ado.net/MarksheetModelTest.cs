namespace Advance.Net.p01ado.net
{
    public class MarksheetModelTest
    {
        public static void Test()
        {

            // TestAdd();
            // TestUpdate();
            // TestSearch();
            // TestDelete();
            // TestFindById();
        }

        public static void TestFindById()
        {
            Marksheet marksheet = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            marksheet.Id = 3;

            model.FindById(marksheet);

            // Displaying a message
            Console.WriteLine("Record FindById Successfully");
        }

        public static void TestDelete()
        {
            Marksheet marksheet = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            marksheet.Id = 3;

            model.Delete(marksheet);

            // Displaying a message  
            Console.WriteLine("Record Deleted Successfully");
        }

        public static void TestSearch()
        {
            Marksheet marksheet = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            model.Search(marksheet);

            // Displaying a message
            Console.WriteLine("Record Display Successfully");
        }

        public static void TestUpdate()
        {
            Marksheet marksheet = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            marksheet.Id = 3;
            marksheet.RollNo = "sk2003";
            model.Update(marksheet);

            // Displaying a message  
            Console.WriteLine("Record Updated Successfully");
        }

        public static void TestAdd()
        {
            Marksheet marksheet = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            marksheet.Id = 3;
            marksheet.RollNo = "sk2003";
            marksheet.FName = "Aniket";
            marksheet.LName = "Kumawat";
            marksheet.Physics = 52;
            marksheet.Chemistry = 67;
            marksheet.Maths = 78;

            model.Add(marksheet);

            // Displaying a message  
            Console.WriteLine("Record Inserted Successfully");
        }
    }
}