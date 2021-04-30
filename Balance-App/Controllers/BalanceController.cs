using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Balance_App.ActionFilters;
using Balance_App.DataAccess;
using Balance_App.Entities;
using Balance_App.ViewModels.Balances;
using Balance_App.ViewModels.Balance;

namespace Balance_App.Controllers
{
    [AuthenticationFilter]
    public class BalanceController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            BalanceRepository repo = new BalanceRepository();
            

            model.Items = repo.GetAll(c => c.UserId == loggedUserId);


            return View(model);
        }

        [HttpGet]
        public IActionResult Share(int id)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            ShareVM model = new ShareVM();

            BalanceRepository balanceRepo = new BalanceRepository();
            model.Balance = balanceRepo.GetFirstOrDefault(u => u.Id == id);

            UserToBalanceRepository userToBalancesRepository = new UserToBalanceRepository();
            model.SharedWith = userToBalancesRepository.GetReferences(
                                                            utc => utc.BalanceId == model.BalanceId,
                                                            utc => utc.ParentUser);

            UsersRepository repo = new UsersRepository();
            model.Users = new List<User>();

            foreach (User item in repo.GetAll())
            {
                if (item.Id == loggedUserId)
                    continue;

                if (model.SharedWith.Where(u => u.Id == item.Id).Count() > 0)
                    continue;

                model.Users.Add(item);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            model.UserIds = model.UserIds ?? new List<int>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                UserToBalanceRepository repo = new UserToBalanceRepository(uow);

                List<UserToBalance> shares = repo.GetAll(utc => utc.BalanceId == model.BalanceId);

                try
                {
                    uow.BeginTransaction();
                    foreach (int userId in model.UserIds)
                    {
                        if (shares.Where(utc => utc.UserId == userId).Count() > 0)
                            continue;

                        UserToBalance userToBalance = new UserToBalance();
                        userToBalance.UserId = userId;
                        userToBalance.BalanceId = model.BalanceId;

                        repo.Insert(userToBalance);
                    }
                    uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.Rollback();
                    throw ex;
                }
            }

            return RedirectToAction("Index", "Balance");
        }

        public IActionResult RevokeAccess(int UserId, int BalanceId)
        {
            UserToBalanceRepository repo = new UserToBalanceRepository();
            UserToBalance item = repo.GetFirstOrDefault(utc =>
                                                            utc.UserId == UserId &&
                                                            utc.BalanceId == BalanceId);

            if (item != null)
                repo.Delete(item);

            return RedirectToAction("Index", "Balance");
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            if (!ModelState.IsValid)
                return View(model);

            BalanceRepository repo = new BalanceRepository();

            Balance item = new Balance();
            item.UserId = loggedUserId;
            item.NameOrType = model.NameOrType;
            item.ExDate = model.ExDate;
            item.BalancesAmound = model.BalanceAmount;



            repo.Insert(item);

            return RedirectToAction("Index", "Balance");
        }

        public IActionResult Delete(int id)
        {
            BalanceRepository repo = new BalanceRepository();

            Balance item = new Balance();
            item.Id = id;

            repo.Delete(item);

            return RedirectToAction("Index", "Balance");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            BalanceRepository repo = new BalanceRepository();

            Balance item = repo.GetById(id);

            if (item == null)
                return RedirectToAction("Index", "Balance");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.NameOrType = item.NameOrType;
            model.ExDate = item.ExDate;
            model.BalanceAmount = item.BalancesAmound;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            BalanceRepository repo = new BalanceRepository();

            Balance item = new Balance();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.NameOrType = model.NameOrType;
            item.ExDate = model.ExDate;
            item.BalancesAmound = model.BalanceAmount;

            repo.Update(item);

            return RedirectToAction("Index", "Balance");
        }
    }
}