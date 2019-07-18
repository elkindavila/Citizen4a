using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citizen4a.Models;
using Microsoft.AspNetCore.Mvc;

namespace Citizen4a.Controllers
{
    public class HomeController : Controller
    {
        UserAdmin useradmin = new UserAdmin();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AgregarUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarUsuario(String user, String pass)
        {
            Users U = new Users()
            {
                LoginUsers=user,
                PassUsers =pass
            };

            useradmin.AgregarUsuario(U);
            return View();
        }
    }
}