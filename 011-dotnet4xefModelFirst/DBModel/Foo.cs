using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet4xefModelFirst.DBModel {


    [Table ("FOO")]
    public class Foo {
        public int ID { get; set; }
    //    public int DummyData { get; set; }
        public Foo() {

        }
    }
}
