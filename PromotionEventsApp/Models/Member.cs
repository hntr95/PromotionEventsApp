﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace PromotionEventsApp.Models
{
    public class Member
    {   
        public int EventId { get; set; }
        public Event  Event{ get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
