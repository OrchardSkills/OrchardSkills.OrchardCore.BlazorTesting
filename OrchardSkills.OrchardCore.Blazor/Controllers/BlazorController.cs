using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrchardSkills.OrchardCore.Blazor.Controllers
{
    public class BlazorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
