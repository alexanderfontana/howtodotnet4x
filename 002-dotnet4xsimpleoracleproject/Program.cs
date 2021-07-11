using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
//ODP.NetCore
//Oracle.ManagedDataAccess 

namespace _002_dotnet4xsimpleoracleproject {
    class Program {
        static void Main(string [] args) {
            Stopwatch sw = new Stopwatch ();
            sw.Start ();
            string conString = "User Id=dummy;Password=dummy;Data Source=localhost:1521/ORCLCDB.localdomain";



            DbProviderFactory factory =
            DbProviderFactories.GetFactory ("Oracle.ManagedDataAccess.Client");

            using (DbConnection conn = factory.CreateConnection ()) {
                conn.ConnectionString = conString;
                try {
                    conn.Open ();
                    OracleCommand cmd = (OracleCommand)factory.CreateCommand ();
                    cmd.Connection = (OracleConnection)conn;

                    //to gain access to ROWIDs of the table
                    cmd.AddRowid = true;
                    cmd.CommandText = "select id  from foo;";

                    OracleDataReader reader = cmd.ExecuteReader ();
                    int visFC = reader.VisibleFieldCount; //Results in 2
                    int hidFC = reader.HiddenFieldCount;  // Results in 1

                    Console.Write ("Visible field count: " + visFC);
                    Console.Write ("Hidden field count: " + hidFC);

                    reader.Dispose ();
                    cmd.Dispose ();
                }
                catch (Exception ex) {
                    Console.WriteLine (ex.Message);
                    Console.WriteLine (ex.StackTrace);
                }


                sw.Stop ();
                Console.WriteLine ($"Das Dauerte: {sw.ElapsedMilliseconds} ms");
                Console.ReadKey ();
            }
        }
    }
}




