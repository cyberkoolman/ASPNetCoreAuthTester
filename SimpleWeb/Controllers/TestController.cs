using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWeb.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
