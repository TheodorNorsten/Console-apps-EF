using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Persistence
{
    class TrainContext : DbContext
    {
        public TrainContext() :base("name=TrainContext")
        {

        }
    }
}
