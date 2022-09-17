namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSeatsAndSeatTypeToTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainSeats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainCabin_Id = c.Int(),
                        TrainSeatType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TrainCabins", t => t.TrainCabin_Id)
                .ForeignKey("dbo.TrainSeatTypes", t => t.TrainSeatType_Id)
                .Index(t => t.TrainCabin_Id)
                .Index(t => t.TrainSeatType_Id);
            
            CreateTable(
                "dbo.TrainSeatTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainSeats", "TrainSeatType_Id", "dbo.TrainSeatTypes");
            DropForeignKey("dbo.TrainSeats", "TrainCabin_Id", "dbo.TrainCabins");
            DropIndex("dbo.TrainSeats", new[] { "TrainSeatType_Id" });
            DropIndex("dbo.TrainSeats", new[] { "TrainCabin_Id" });
            DropTable("dbo.TrainSeatTypes");
            DropTable("dbo.TrainSeats");
        }
    }
}
