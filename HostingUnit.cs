using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_8772_9333
{
    public class HostingUnit
    {
        public string UnitName { set; get; }
        public int Rooms { set; get; }
        public bool IsSwimmimgPool { set; get; }
        public List<DateTime> AllOrders { set; get; }
        public List<string> Uris { set; get; }
        public HostingUnit()
        {
            AllOrders = new List<DateTime>();
            Uris = new List<string>();
            IsSwimmimgPool = false;
            Rooms = 0;
        }

    }
}
