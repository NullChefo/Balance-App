using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Balance_App.DataAccess;
using Balance_App.Entities;
using Balance_App.ViewModels.Users;
using Balance_App.ActionFilters;

namespace Balance_App.Controllers
{
   
    public class UsersController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            UsersRepository repo = new UsersRepository();
            model.Items = repo.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UsersRepository repo = new UsersRepository();

            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.IsDeleted = false;

            repo.Insert(item);

            return RedirectToAction("Index", "Balance"  );
        }
        [AuthenticationFilter]
        public IActionResult Delete(int id)
        {
            UsersRepository repo = new UsersRepository();

            User item = new User();
            item.Id = id;

            repo.Delete(item);

            return RedirectToAction("Index", "Users");
        }
        [AuthenticationFilter]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            UsersRepository repo = new UsersRepository();

            User item = repo.GetById(id);

            if (item == null)
                return RedirectToAction("Index", "Users");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UsersRepository repo = new UsersRepository();

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            repo.Update(item);

            return RedirectToAction("Index", "Users");
        }
    }
}
