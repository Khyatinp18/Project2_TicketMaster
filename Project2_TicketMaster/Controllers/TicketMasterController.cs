using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project2_TicketMaster.Models;

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
        public async Task<IActionResult> GetEventList()
        {
            var response = await _client.GetAsync($"attractions.json?apikey={ticketMasterApiKey}");
            var events = await response.Content.ReadAsAsync<EventRootobject>();
            var attractions = events._embedded;
            return View(attractions);
        }

        [HttpGet]
        public async Task<IActionResult> GetEventBySource()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetEventBySource(string source)
        {
            var response = await _client.GetAsync($"attractions.json?source={source}&apikey={ticketMasterApiKey}");
            var events = await response.Content.ReadAsAsync<EventRootobject>();

            return View("GetEventList",events);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}