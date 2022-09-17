using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Core.Domain
{
    public class Train
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public TrainRoute Route { get; set; }
        public IList<TrainCabin> TrainCabins { get; set; }

    }
}
