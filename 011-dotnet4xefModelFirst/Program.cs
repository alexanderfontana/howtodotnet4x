using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using Oracle.ManagedDataAccess.EntityFramework;
using dotnet4xefModelFirst.DBModel;

//https://entityframework-extensions.net/oracle-provider
// https://www.programmersought.com/article/91055016143/
namespace dotnet4xefModelFirst {
    class Program {
        static void Main(string [] args) {
            Stopwatch sw = new Stopwatch ();
            sw.Start ();
            try {
                using (FooContext ctx = new FooContext ()) {
                    var resFoo = (from f in ctx.Foo select f).ToList ();
                    if (resFoo.Count > 0) {
                        Console.WriteLine ("Data available:");
                    }
                    if (resFoo.Count == 0) {
                        Console.WriteLine ("No Data available");
                    }
                    foreach (Foo item in resFoo) {
                        Console.WriteLine (item.ID);
                    }
                }
            }
            catch (OracleException oraex) {
                Console.WriteLine ("Oracle Errors ");
                foreach (OracleError err in oraex.Errors) {
                    Console.WriteLine (err.Message);
                }
            }
            catch (Exception ex) {
                Console.WriteLine ("Exception ");
                Console.WriteLine (ex.Message.ToString ());
                if (ex.InnerException != null) {
                    Console.WriteLine (ex.InnerException.ToString ());
                }
            }


            // Hinzufügen einer Person
            Console.WriteLine ("Start-Person wird hinzufefügt");
            using (FooContext ctx = new FooContext ()) {
                Personen p = new Personen ();
                p.Vorname = "Hans";
                ctx.Personen.Add (p);
                ctx.SaveChanges ();
            }
            Console.WriteLine ("Ende-Person wird hinzufefügt");



            Console.WriteLine ("Abfrage Personen....");
            try {
                using (FooContext ctx = new FooContext ()) {
                    var resPersonen = (from f in ctx.Personen select f).ToList ();
                    if (resPersonen.Count > 0) {
                        Console.WriteLine ("Data available:");
                        foreach (Personen item in resPersonen) {
                            Console.WriteLine ($"ID: {item.ID} vorname:{item.Vorname}");
                        }
                    }
                }
            }
            catch (OracleException oraex) {
                Console.WriteLine ("Oracle Errors ");
                foreach (OracleError err in oraex.Errors) {
                    Console.WriteLine (err.Message);
                }
            }
            catch (Exception ex) {
                Console.WriteLine ("Exception ");
                Console.WriteLine (ex.Message.ToString ());
                if (ex.InnerException != null) {
                    Console.WriteLine (ex.InnerException.ToString ());
                }

            }



            Console.ReadKey ();
        }
    }
}




