﻿using BookStore.DAL;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private BooksContext booksContext = new BooksContext();
        // GET: Home
        public ActionResult Index()
        {
            var CategoryList = booksContext.Categories.ToList();
            return View();
        }
    }
}