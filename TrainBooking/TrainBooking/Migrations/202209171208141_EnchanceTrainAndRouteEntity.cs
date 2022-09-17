namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnchanceTrainAndRouteEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trains", "CurrentRoute_Id", "dbo.TrainRoutes");
            DropIndex("dbo.Trains", new[] { "CurrentRoute_Id" });
            RenameColumn(table: "dbo.Trains", name: "CurrentRoute_Id", newName: "RouteId");
            AlterColumn("dbo.TrainRoutes", "TravelTime", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.TrainRoutes", "DepartureLocation", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.TrainRoutes", "ArrivalLocation", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Trains", "RouteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Trains", "RouteId");
            AddForeignKey("dbo.Trains", "RouteId", "dbo.TrainRoutes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trains", "RouteId", "dbo.TrainRoutes");
            DropIndex("dbo.Trains", new[] { "RouteId" });
            AlterColumn("dbo.Trains", "RouteId", c => c.Int());
            AlterColumn("dbo.TrainRoutes", "ArrivalLocation", c => c.String());
            AlterColumn("dbo.TrainRoutes", "DepartureLocation", c => c.String());
            AlterColumn("dbo.TrainRoutes", "TravelTime", c => c.String());
            RenameColumn(table: "dbo.Trains", name: "RouteId", newName: "CurrentRoute_Id");
            CreateIndex("dbo.Trains", "CurrentRoute_Id");
            AddForeignKey("dbo.Trains", "CurrentRoute_Id", "dbo.TrainRoutes", "Id");
        }
    }
}
