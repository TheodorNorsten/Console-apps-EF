namespace TrainBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainCabinToTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainCabins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trains", t => t.TrainId, cascadeDelete: true)
                .Index(t => t.TrainId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainCabins", "TrainId", "dbo.Trains");
            DropIndex("dbo.TrainCabins", new[] { "TrainId" });
            DropTable("dbo.TrainCabins");
        }
    }
}
