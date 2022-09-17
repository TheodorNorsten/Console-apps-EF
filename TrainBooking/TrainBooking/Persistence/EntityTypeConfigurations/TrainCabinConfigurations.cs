using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBooking.Core.Domain;

namespace TrainBooking.Persistence.EntityTypeConfigurations
{
    public class TrainCabinConfigurations : EntityTypeConfiguration<TrainCabin>
    {
        public TrainCabinConfigurations()
        {
            HasRequired(s => s.Train)
                .WithMany(t => t.TrainCabins)
                .HasForeignKey(s => s.TrainId);
        }
    }
}
