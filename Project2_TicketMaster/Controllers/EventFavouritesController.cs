﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project2_TicketMaster.Models;

namespace Project2_TicketMaster.Controllers
{
    public class EventFavouritesController : Controller
    {
        private readonly EventFavouritesContext _context;

        public EventFavouritesController(EventFavouritesContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> AddToFavorites(Favourite favourite)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _context.Favourite.Add(favourite);
        //        _context.SaveChanges();
        //    }
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}