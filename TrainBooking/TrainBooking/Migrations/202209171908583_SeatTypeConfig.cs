namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeatTypeConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrainSeatTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrainSeatTypes", "Name", c => c.String());
        }
    }
}
