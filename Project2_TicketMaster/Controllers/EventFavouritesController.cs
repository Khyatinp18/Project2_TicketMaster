using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
 
        public IActionResult AddToFavorites(Attraction attraction)
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Favourite newfavourite = new Favourite { OwnerId = id, Name = attraction.name, EventType = attraction.type, Url = attraction.url, Locale = attraction.locale };
            
            if (ModelState.IsValid)
            {
                _context.Favourite.Add(newfavourite);
                _context.SaveChanges();

                return RedirectToAction("FavouriteList");
            }
            else
            {
                return RedirectToAction("GetEventList");
            }
        }

        public IActionResult FavouriteList()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Favourite> favouriteList = _context.Favourite.Where(x => x.OwnerId == id).ToList();
            return View(favouriteList);

        }

        public IActionResult RemoveFromFavorites(int id)
        {
            Favourite found = _context.Favourite.Find(id);
            if (found != null)
            {
                _context.Favourite.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("FavouriteList");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}