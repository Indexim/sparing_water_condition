using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sparing_Web.DBContext;
using Sparing_Web.Models;
using System;
using System.Diagnostics;

namespace Sparing_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBContext _dbcontext;
        private IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, AppDBContext context, IConfiguration configuration)
        {
            _logger = logger;
            _dbcontext = context;
            _config = configuration;
        }

        public IActionResult Index() { return View(); }

        public async Task<IActionResult> Gets()
        {
            var water = await _dbcontext.WaterConditions.OrderByDescending(x => x.Pid).Take(10).ToListAsync();
            return Ok(new { Status = StatusCodes.Status200OK, Message = "", Data = water });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
