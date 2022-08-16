using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Model
{
    public class Geo
    {
        public double lat { get; set; }
        public double lng { get; set; }

        public Geo(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }

        public Geo() { }
    }
}
