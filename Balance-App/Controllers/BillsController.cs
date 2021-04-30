using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Balance_App.ActionFilters;
using Balance_App.DataAccess;
using Balance_App.Entities;
using Balance_App.ViewModels.Bills;


namespace Balance_App.Controllers
{
    [AuthenticationFilter]
    public class BillsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            BalanceRepository balanceRepo = new BalanceRepository();
            BillsRepository billsRepo = new BillsRepository();

            model.Balance = balanceRepo.GetById(model.ParentId);
            model.Items = billsRepo.GetAll(p => p.BalanceId == model.ParentId);
      

            return View(model);
        }




       
        [HttpGet]
        public IActionResult Create(int parentId)
        {
            CreateVM model = new CreateVM();

            model.Bill_BalanceId = parentId;



            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            BillsRepository repo = new BillsRepository();

            Bill item = new Bill();

            item.BalanceId = model.Bill_BalanceId;
            item.Name = model.BillName;
            item.BillAmount = model.BillAmount;


            repo.Insert(item);

            return RedirectToAction("Index", "Bills", new { ParentId = model.Bill_BalanceId });
        }

        public IActionResult Delete(int parentId)
        {
            BillsRepository repo = new BillsRepository();
            Bill item = repo.GetById(parentId);

            if (item == null)
                return RedirectToAction("Index", "Balance");

            int BalanceId = item.BalanceId;

            repo.Delete(item);

            return RedirectToAction("Index", "balance", new { ParentId = BalanceId });
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            BillsRepository repo = new BillsRepository();

            Bill item = repo.GetById(id);

            if (item == null)
                return RedirectToAction("Index", "Balance");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.BalanceId = item.BalanceId;
            model.BillName = item.Name;
            model.BillAmount = item.BillAmount;

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            BillsRepository repo = new BillsRepository();

            Bill item = new Bill();
            item.Id = model.Id;
            item.BalanceId = model.BalanceId;
            item.Name = model.BillName;
            item.BillAmount = model.BillAmount;


            repo.Update(item);

            return RedirectToAction("Index", "Balance");

        }
      

    }


}

