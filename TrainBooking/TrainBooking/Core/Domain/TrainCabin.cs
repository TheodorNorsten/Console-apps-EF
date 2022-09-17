using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Core.Domain
{
    public class TrainCabin
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public Train Train { get; set; }
        public IList<TrainSeat> TrainSeats { get; set; }
    }
}
