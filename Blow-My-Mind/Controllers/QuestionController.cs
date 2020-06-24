using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Blow_My_Mind.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
