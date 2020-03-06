using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Project2_TicketMaster.Controllers
{
    public class TicketMasterController : Controller
    {
        private readonly string ticketMasterApiKey;
        public TicketMasterController(IConfiguration configuration)
        {
            ticketMasterApiKey = configuration.GetSection("APIKeys")["APINameKey"];
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}