﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Model;

namespace TP3
{
    public class Root
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Current current { get; set; }
        public List<Minutely> minutely { get; set; }
        public List<Hourly> hourly { get; set; }
        public List<Daily> daily { get; set; }
        public List<List> list { get; set; }
        public City city { get; set; }
    }

}
