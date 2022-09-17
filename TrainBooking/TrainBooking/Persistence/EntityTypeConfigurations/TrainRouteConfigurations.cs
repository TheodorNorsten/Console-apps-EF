using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBooking.Core.Domain;

namespace TrainBooking.Persistence.EntityTypeConfigurations
{
    public class TrainRouteConfigurations: EntityTypeConfiguration<TrainRoute>
    {
        public TrainRouteConfigurations()
        {
            Property(t => t.ArrivalLocation).IsRequired().HasMaxLength(255);
            Property(t => t.DepartureLocation).IsRequired().HasMaxLength(255);
            Property(t => t.TravelTime).IsRequired().HasMaxLength(255);
        }
    }
}
