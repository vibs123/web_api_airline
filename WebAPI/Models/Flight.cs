using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Flight
    {
        public string flight_number {get; set;}

        public string time_of_dept { get; set; }

        public string time_of_arr { get; set; }

        public string  dep_city{ get; set; }

        public string arr_city { get; set; }
        public string duration { get; set; }


    }
}
