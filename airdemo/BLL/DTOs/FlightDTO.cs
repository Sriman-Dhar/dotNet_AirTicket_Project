﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public string AirLineName { get; set; }
        public DateTime DepDate { get; set; }
        public DateTime DesDate { get; set; }
        public string DepLoc { get; set; }
        public string DesLoc { get; set; }
    }
}
