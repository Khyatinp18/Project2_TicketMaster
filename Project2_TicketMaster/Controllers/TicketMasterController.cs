using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project2_TicketMaster.Models;
using PagedList;
using PagedList.Mvc;

namespace Project2_TicketMaster.Controllers
{
    public class TicketMasterController : Controller
    {
        private readonly string ticketMasterApiKey;
        private readonly HttpClient _client;

        public TicketMasterController(IHttpClientFactory client, IConfiguration configuration)
        {
            ticketMasterApiKey = configuration.GetSection("APIKeys")["APINameKey"];
            _client = client.CreateClient();
            _client.BaseAddress = new Uri("https://app.ticketmaster.com/discovery/v2/");
        }
        [HttpGet]
        public IActionResult GetEventBySource()
        {
            return View("GetEventBySource");
        }

        [HttpGet]
        public IActionResult GetEventByCountry()
        {
            return View("GetEventByCountry");
        }
        [HttpPost]
        public async Task<IActionResult> GetEventBySource(string source, int page)
        {
            int pageOption;
            if (page == 0)
            {
                pageOption = 0;
            }

            else
            {
                pageOption = page;
            }
            var response = await _client.GetAsync($"attractions.json?apikey={ticketMasterApiKey}&page={pageOption}&source={source}");
            var events = await response.Content.ReadAsAsync<EventRootobject>();
            return View("GetEventList",events);
        }

        public async Task<IActionResult> GetEventList(int page)
        {
            int pageOption;
            if (page == 0)
            {
                pageOption = 0;
            }

            else
            {
                pageOption = page;
            }
            var response = await _client.GetAsync($"attractions.json?apikey={ticketMasterApiKey}&page={pageOption}");
            var events = await response.Content.ReadAsAsync<EventRootobject>();
            return View(events);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}