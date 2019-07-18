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
            return View(useradmin.GetUsers());
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

            try
            {
                useradmin.AgregarUsuario(U);
            }
            catch (Exception ex)
            {

                ViewBag.MensajeError = ex.Message;
                return View();
            }

            return RedirectToAction("Index");
        }

        public IActionResult EliminarUsuario(int id)
        {
            useradmin.EliminarUsuario(id);
            return RedirectToAction("Index");
        }

        public IActionResult ModificarUsuario(int id)
        {

            return View(useradmin.GetUsuarioById(id));
        }

        [HttpPost]
        public IActionResult ModificarUsuario(int id,string user, string pass)
        {
            Users U = new Users()
            {
                LoginUsers = user,
                PassUsers = pass
            };

            try
            {
                useradmin.ModificarUsuario(U,id);
            }
            catch (Exception ex)
            {

                ViewBag.MensajeError = ex.Message;
                return View(useradmin.GetUsuarioById(id));
            }

            return RedirectToAction("Index");
        }
    }
}