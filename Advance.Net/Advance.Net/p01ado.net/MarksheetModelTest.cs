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
                long pk = 1L;
                m = model.findById(pk);
                if (m.iD == 0)
                {
                    Console.WriteLine("Find By pk fail");
                }
                else 
                {
                    Console.Write(m.iD + "\t");
                    Console.Write(m.rollNo + "\t");
                    Console.Write(m.fName + "\t");
                    Console.Write(m.lName + "\t");
                    Console.Write(m.physics + "\t");
                    Console.Write(m.chemistry + "\t");
                    Console.WriteLine(m.maths + "\t");
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

            m.iD = 5;
            model.delete(m);

            Console.WriteLine("Record Deleted Successfully");
        }

        public static void testSearch()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();
            IList list = new ArrayList();

            m.iD = 2;
            list = model.search();

            foreach (Object o in list)
            {
                m = (Marksheet)o;
                Console.Write(m.iD + "\t");
                Console.Write(m.rollNo + "\t");
                Console.Write(m.fName + "\t");
                Console.Write(m.lName + "\t");
                Console.Write(m.physics + "\t");
                Console.Write(m.chemistry + "\t");
                Console.WriteLine(m.maths);
            }
        }
        public static void testUpdate()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            m.iD = 4;
            m.rollNo = "sk2004";
            m.fName = "Rahul";
            m.lName = "Verma";
            m.physics = 55;
            m.chemistry = 48;
            m.maths = 62;
            model.update(m);

            Console.WriteLine("Record Updated Successfully");
        }

        public static void testAdd()
        {
            Marksheet m = new Marksheet();
            MarksheetModel model = new MarksheetModel();

            m.rollNo = "sk2005";
            m.fName = "Pankaj";
            m.lName = "Rathod";
            m.physics = 35;
            m.chemistry = 64;
            m.maths = 81;

            model.add(m);
            Console.WriteLine("Record Inserted Successfully");
        }
    }
}