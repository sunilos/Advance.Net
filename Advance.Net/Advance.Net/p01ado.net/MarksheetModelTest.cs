namespace Advance.Net.p01ado.net
{
    public class MarksheetModelTest
    {
        public static void Test()
        {

            // TestAdd();
            // TestUpdate();
             TestDisplay();
            // TestDelete();
        }

        public static void TestDelete()
        {
            Marksheet bean = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            model.Delete(bean);
        }

        public static void TestDisplay()
        {
            Marksheet bean = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            model.Display(bean);
        }

        public static void TestUpdate()
        {
            Marksheet bean = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            model.Update(bean);
        }

        public static void TestAdd()
        {
            Marksheet bean = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            model.Add(bean);
        }
    }
}