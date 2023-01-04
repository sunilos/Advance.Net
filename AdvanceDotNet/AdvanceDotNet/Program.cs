using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.SqlClient;
using Advance.Net.p01ado.net;
using MYSQLConnect.p01ado.net;

namespace Advance.Net
{
    public class Program
    {
        
        // The main entry point for the application.
       
        [STAThread]
        public static void Main(String[] args)
        {
            GetData.Test();
            /*DDLStatements d = new DDLStatements();
            //d.Add();
            //d.Update();
            //d.Delete();
            //d.Display();*/
            /*CrudOparetion c = new CrudOparetion();
            //c.Update();
            //c.Add();
            //c.Display();
            //c.Delete();*/
        }
    }
}