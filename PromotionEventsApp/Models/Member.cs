﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEventsApp.Models
{
    public class Member
    {
        public Guid EventID { get; set; }
        public Event  Event{ get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
