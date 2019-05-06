﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEventsApp.Models
{
    public class EventSpot
    {
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public int SpotId { get; set; }
        public virtual Spot Spot { get; set; }
        public int Value { get; set; }
    }   
}
