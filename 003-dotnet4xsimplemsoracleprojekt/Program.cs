using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Data.Common;

namespace _003_dotnet4xsimpleoracleproject {
    class Program {
        static void Main(string [] args) {
            Stopwatch sw = new Stopwatch ();
            sw.Start ();
            string constring = "user id=dummy;password=dummy;data source=localhost:1521/orclcdb.localdomain";
            string querystring = "select id from foo";

            try {
                using (OracleConnection connection = new OracleConnection (constring)) {
                    OracleCommand command = new OracleCommand (querystring, connection);
                    connection.Open ();
                    using (OracleDataReader reader = command.ExecuteReader ()) {
                        // Always call Read before accessing data.
                        while (reader.Read ()) {
                            Console.WriteLine (reader.GetInt32 (0) );
                        }
                    }
                }

            }
            catch (Exception ex) {
                // System.Data.OracleClient erfordert version 8.1.7 oder höher der Oracle-Clientsoftware.
                Console.WriteLine (ex.Message);
                throw;
            }

            sw.Stop ();
            Console.WriteLine ($"Das Dauerte: {sw.ElapsedMilliseconds} ms");
            Console.ReadKey ();
        }
    }
}




