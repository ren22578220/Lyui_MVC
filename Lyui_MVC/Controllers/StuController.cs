using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lyui_MVC.Controllers
{
    public class StuController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
