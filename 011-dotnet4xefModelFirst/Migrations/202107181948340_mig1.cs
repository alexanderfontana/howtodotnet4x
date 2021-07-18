namespace _002_dotnet4xsimpleoracleproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "DUMMY.FOO",
            //    c => new
            //        {
            //            ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            CreateTable(
                "DUMMY.Personen",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Vorname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("DUMMY.Personen");
            DropTable("DUMMY.FOO");
        }
    }
}
