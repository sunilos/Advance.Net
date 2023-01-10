namespace Advance.Net.p01ado.net
{
    public class MarksheetModelTest
    {
        public static void Test()
        {

            TestAdd();
        }

        public static void TestAdd()
        {
            MarksheetBean bean = new MarksheetBean();
            MarksheetModel model = new MarksheetModel();

            bean.setId(1);
            bean.setRollNo("sk2001");
            bean.setFName("Shubham");
            bean.setLName("Kumawat");
            bean.setPhysics(99);
            bean.setChemistry(99);
            bean.setMaths(99);

            model.Add(bean);
        }
    }
}