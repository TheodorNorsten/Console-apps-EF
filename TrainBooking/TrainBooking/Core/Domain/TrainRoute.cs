using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Core.Domain
{
    public class TrainRoute
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string TravelTime { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public IList<Train> Trains { get; set; }
    }
}
