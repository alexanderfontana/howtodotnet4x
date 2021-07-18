using dotnet4xefModelFirst.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet4xefModelFirst.DBModel {
    public class FooContext : DbContext {
        public FooContext() : base ("OracleDbContext") {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema ("DUMMY");
        }

        public DbSet<Foo> Foo { get; set; }
    }
}

