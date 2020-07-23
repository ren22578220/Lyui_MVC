using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lyui_MVC.Controllers
{
    public class ClssController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
