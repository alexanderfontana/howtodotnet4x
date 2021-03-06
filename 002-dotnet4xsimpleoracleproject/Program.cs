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
                    cmd.AddRowid = true;
                    cmd.CommandText = "select id  from foos;";
                    OracleDataReader reader = cmd.ExecuteReader ();
                   while (reader.Read()) {
                        int id = reader.GetInt32 (0);
                        Console.WriteLine ($"gelesen Wert id: {id}");
                    }
                    reader.Dispose ();
                    cmd.Dispose ();
                }
                catch(OracleException oraex) {
                    Console.WriteLine ("Oracle Errors ");
                    foreach (OracleError err in oraex.Errors) {
                        Console.WriteLine ( err.Message);
                   }
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




