using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Balance_App.Models;
using Balance_App.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Balance_App.Entities;
using Balance_App.DataAccess;
using Balance_App.ViewModels;

namespace Balance_App.Controllers
{
  
         public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Logout()
            {
                this.HttpContext.Session.Remove("LoggedUserId");

                return RedirectToAction("Index", "Home");
            }

            [HttpGet]
            public IActionResult Login()
            {
                if (this.HttpContext.Session.GetString("LoggedUserId") != null)
                    return RedirectToAction("Index", "Home");

                return View();
            }

            [HttpPost]
            public IActionResult Login(LoginVM model)
            {
                if (this.HttpContext.Session.GetString("LoggedUserId") != null)
                    return RedirectToAction("Index", "Home");

                if (!ModelState.IsValid)
                    return View(model);

                UsersRepository repo = new UsersRepository();
                User loggedUser = repo.GetFirstOrDefault(u =>
                                                u.Username == model.Username &&
                                                u.Password == model.Password);

                if (loggedUser == null)
                {
                    ModelState.AddModelError("AuthenticationFailed", "Wrong username or password");
                    return View(model);
                }

                this.HttpContext.Session.SetString("LoggedUserId", loggedUser.Id.ToString());
                this.HttpContext.Session.SetString("LoggedUserUsername", loggedUser.Username);

                return RedirectToAction("Index", "Balance");
            }
        }
    }