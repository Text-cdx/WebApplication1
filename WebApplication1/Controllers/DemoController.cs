﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Query()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}