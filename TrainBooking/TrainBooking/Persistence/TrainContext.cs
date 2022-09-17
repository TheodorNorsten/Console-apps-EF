using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBooking.Core.Domain;
using TrainBooking.Persistence.EntityTypeConfigurations;

namespace TrainBooking.Persistence
{
    class TrainContext : DbContext
    {
        public TrainContext() : base("name=TrainContext") 
        { 
            
        }
        public DbSet<Train> Trains { get; set; }
        public DbSet<TrainRoute> TrainRoutes { get; set; }
        public DbSet<TrainCabin> TrainCabins { get; set; }
        public DbSet<TrainSeat> TrainSeats { get; set; }
        public DbSet<TrainSeatType> TrainSeatTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TrainConfigurations());
            modelBuilder.Configurations.Add(new TrainRouteConfigurations());
            modelBuilder.Configurations.Add(new TrainCabinConfigurations());
            modelBuilder.Configurations.Add(new TrainSeatTypeConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}
