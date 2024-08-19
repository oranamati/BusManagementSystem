using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5781_02_7776
{
    class BusStationExceptions:Exception //our class to exeptions
    {
        public BusStationExceptions():base() { }
        public BusStationExceptions(string exp ) : base(exp) { }
    }
}
