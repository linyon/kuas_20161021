﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20161021.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult MemberIndex()
        {
            return View();
        }
    }
}