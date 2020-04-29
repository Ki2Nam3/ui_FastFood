using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fastFood.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }

        // đặng đạt thêm
        public ActionResult admin()
        {
            return View();
        }
        public ActionResult qlyBan()
        {
            return View();
        }
        public ActionResult qlyChiTietDonDat()
        {
            return View();
        }
        public ActionResult qlyDonDatHang()
        {
            return View();
        }
        public ActionResult qlyLoaiMatHang()
        {
            return View();
        }
        public ActionResult qlyMatHang()
        {
            return View();
        }
        public ActionResult qlyUsers()
        {
            return View();
        }
        //---------------------------------------------

        // GET: home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
