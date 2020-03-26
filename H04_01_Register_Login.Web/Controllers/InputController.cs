using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H04_01_Register_Login.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H04_01_Register_Login.Web.Controllers
{
    public class InputController : Controller
    {
        public IActionResult Index()
        {
            InputVm model = new InputVm();
            return View(model);
        }
    }
}