using System.Data;

namespace Advance.Net.p01ado.net
{
    public class TestDataSet1
    {
        public static void Test()
        {
            try
            { // building the EmployeeDetails table using DataTable
                DataTable EmployeeDetails = new DataTable("EmployeeDetails");
                //to create the column and schema
                DataColumn EmployeeID = new DataColumn("EmpID", typeof(Int32));
                EmployeeDetails.Columns.Add(EmployeeID);
                DataColumn EmployeeName = new DataColumn("EmpName", typeof(string));
                EmployeeDetails.Columns.Add(EmployeeName);
                DataColumn EmployeeMobile = new DataColumn("EmpMobile", typeof(string));
                EmployeeDetails.Columns.Add(EmployeeMobile);
                //to add the Data rows into the EmployeeDetails table
                EmployeeDetails.Rows.Add(1001, "Andrew", "9000322579");
                EmployeeDetails.Rows.Add(1002, "Briddan", "9081223457");
                // to create one more table SalaryDetails
                DataTable SalaryDetails = new DataTable("SalaryDetails");
                //to create the column and schema
                DataColumn SalaryId = new DataColumn("SalaryID", typeof(Int32));
                SalaryDetails.Columns.Add(SalaryId);
                DataColumn empId = new DataColumn("EmployeeID", typeof(Int32));
                SalaryDetails.Columns.Add(empId);
                DataColumn empName = new DataColumn("EmployeeName", typeof(string));
                SalaryDetails.Columns.Add(empName);
                DataColumn SalaryPaid = new DataColumn("Salary", typeof(Int32));
                SalaryDetails.Columns.Add(SalaryPaid);
                //to add the Data rows into the SalaryDetails table
                SalaryDetails.Rows.Add(10001, 1001, "Andrew", 42000);
                SalaryDetails.Rows.Add(10002, 1002, "Briddan", 30000);
                //to create the object for DataSet
                DataSet dataSet = new DataSet();
                //Adding DataTables into DataSet
                dataSet.Tables.Add(EmployeeDetails);
                dataSet.Tables.Add(SalaryDetails);
                Console.WriteLine("\n\n\tUSING DATASET");
                Console.WriteLine("\n\nEmployeeDetails Table Data: \n");
                //to reterieve the DataTable from dataset using the Index position
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine(row["EmpID"] + ", " + row["EmpName"] + ", " + row["EmpMobile"]);
                }
                Console.WriteLine();
                //SalaryDetails Table
                Console.WriteLine("\nOrderDetails Table Data: \n");
                //retrieving DataTable from the DataSet using name of the table
                foreach (DataRow row in dataSet.Tables["SalaryDetails"].Rows)
                {
                    Console.WriteLine(row["SalaryID"] + ", " + row["EmployeeID"] + ", " + row["EmployeeName"] + ", " + row["Salary"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPS, Error.\n" + e);
            }
            Console.ReadKey();
        }
    }
}