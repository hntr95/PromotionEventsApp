﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PromotionEventsApp.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index() => View();
    }
}