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

            FooContext ctx = new FooContext ();

            var res = (from f in ctx.Foo select f).ToList ();
            int i = 0;
            i++;
        }
    }
}




