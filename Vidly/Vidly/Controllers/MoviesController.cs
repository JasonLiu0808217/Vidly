﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
            // return Content("Hellow World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortby = "name"});
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortby))
            {
                sortby = "Name";
            }
            return Content(string.Format("pageIndex = {0}&sortBy = {1}", pageIndex, sortby));
        }
    }
}