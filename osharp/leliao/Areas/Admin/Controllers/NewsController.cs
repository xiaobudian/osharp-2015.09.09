using OSharp.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSharp.Core.Data.Entity;
using OSharp.Demo.Dtos.Infos;

namespace leliao.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        public INewsContract service { get; set; }
        // GET: Admin/News
        public ActionResult Index()
        {

            return View(service.News.Select(w => new NewsDto { }).ToList());
        }

        // GET: Admin/News/Details/5
        public ActionResult Details(int id)
        {
            var news = service.News.FirstOrDefault(w => w.Id == id);
            if (news == null)
            {
                return new HttpNotFoundResult();
            }
            var newsDto = news.MapTo<NewsDto>();
            return View(newsDto);
        }

        // GET: Admin/News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/News/Create
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

        // GET: Admin/News/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/News/Edit/5
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

        // GET: Admin/News/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/News/Delete/5
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
