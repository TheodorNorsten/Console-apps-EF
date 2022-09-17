namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainAndTrainRoutesModelToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureTime = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        TravelTime = c.String(),
                        DepartureLocation = c.String(),
                        ArrivalLocation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentRoute_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TrainRoutes", t => t.CurrentRoute_Id)
                .Index(t => t.CurrentRoute_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trains", "CurrentRoute_Id", "dbo.TrainRoutes");
            DropIndex("dbo.Trains", new[] { "CurrentRoute_Id" });
            DropTable("dbo.Trains");
            DropTable("dbo.TrainRoutes");
        }
    }
}
