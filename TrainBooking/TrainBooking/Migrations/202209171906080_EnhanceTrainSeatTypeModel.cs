namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhanceTrainSeatTypeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainSeats", "CabinId", c => c.Int(nullable: false));
            AddColumn("dbo.TrainSeats", "SeatId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrainSeats", "SeatId");
            DropColumn("dbo.TrainSeats", "CabinId");
        }
    }
}
