using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Core.Domain
{
   public class TrainSeat
    {
        public int Id { get; set; }
        public int CabinId { get; set; }
        public TrainCabin TrainCabin { get; set; }
        public int SeatId { get; set; }
        public TrainSeatType TrainSeatType { get; set; }
    } 
}
