using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBooking.Core.Domain;

namespace TrainBooking.Persistence.EntityTypeConfigurations
{
    class TrainConfigurations : EntityTypeConfiguration<Train>
    {
        public TrainConfigurations()
        {
            HasRequired(t => t.Route)
                .WithMany(r => r.Trains)
                .HasForeignKey(t => t.RouteId);


        }
    }
}
