using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MihailTestApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MihailTestApp.Controllers
{
    public class HomeController : Controller
    {

        VRGameContext db;
        public HomeController(VRGameContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.VRGames.ToList());
        }
    }
}
