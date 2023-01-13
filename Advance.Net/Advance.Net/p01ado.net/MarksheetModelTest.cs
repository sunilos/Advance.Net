using MySqlX.XDevAPI;
using System.Collections;
using System.Collections.Generic;

namespace Advance.Net.p01ado.net
{
    public class MarksheetModelTest
    {
        public static void Test()
        {

            // testAdd();
            // testUpdate();
            // testSearch();
            // testDelete();
            // testFindById();
        }

        public static void testFindById()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            try
            {
                long pk = 1l;
                m = model.findById(pk);
                if (m.Id == 0)
                {
                    Console.WriteLine("Find By pk fail");
                }
                else 
                {
                    Console.Write(m.Id);
                    Console.Write(m.RollNo);
                    Console.Write(m.FName);
                    Console.Write(m.LName);
                    Console.Write(m.Physics);
                    Console.Write(m.Chemistry);
                    Console.Write(m.Maths);
                }
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void testDelete()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            m.Id = 5;
            model.delete(m);

            Console.WriteLine("Record Deleted Successfully");
        }

        public static void testSearch()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();
            IList list = new ArrayList();

            m.Id = 2;
            list = model.search();

            foreach (Object o in list)
            {
                m = (Marksheet)o;
                Console.WriteLine(m.Id);
                Console.WriteLine(m.RollNo);
                Console.WriteLine(m.FName);
                Console.WriteLine(m.LName);
                Console.WriteLine(m.Physics);
                Console.WriteLine(m.Chemistry);
                Console.WriteLine(m.Maths);
            }
        }
        public static void testUpdate()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            m.Id = 4;
            m.RollNo = "sk2004";
            m.FName = "Rahul";
            m.LName = "Verma";
            m.Physics = 55;
            m.Chemistry = 48;
            m.Maths = 62;
            model.update(m);

            Console.WriteLine("Record Updated Successfully");
        }

        public static void testAdd()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            m.RollNo = "sk2003";
            m.FName = "Aniket";
            m.LName = "Kumawat";
            m.Physics = 52;
            m.Chemistry = 67;
            m.Maths = 78;

            model.add(m);
            Console.WriteLine("Record Inserted Successfully");
        }
    }
}