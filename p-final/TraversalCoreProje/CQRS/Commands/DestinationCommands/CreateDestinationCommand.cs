﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public double Price { get; set; }
        public string DayNight { get; set; }
        public bool Status { get; set; }
        public int GuideID { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string CoverImage { get; set; }
    }
}
