using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotnet4xefModelFirst.DBModel {

    [Table("Personen")]
    public class Personen {

        [Key]
        public int ID { get; set; }

        public string Vorname{ get; set; }
        public Personen() {

        }
    }
}