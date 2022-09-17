using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBooking.Core.Domain;

namespace TrainBooking.Persistence.EntityTypeConfigurations
{
    public class TrainSeatTypeConfigurations : EntityTypeConfiguration<TrainSeatType>
    {
        public TrainSeatTypeConfigurations()
        {
            Property(s => s.Name).HasMaxLength(255).IsRequired();
        }
    }
}
