﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightPlannerWeb.Models
{
    public class SearchFlight
    {
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public string DepartureDate { get; set; }
    }
}
