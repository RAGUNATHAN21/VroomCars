using Assesment.Models;
using Class.Business.Interface;
using Class.Repositary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BusinessInterface _businessInterface;
        public HomeController(BusinessInterface businessInterface)
        {
            _businessInterface = businessInterface;
        }

        public async Task<IActionResult> Index()
        {
            List<EmployeeVM> employees = await _businessInterface.GetAllEmployees();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
       /* public async Task<IActionResult> Create(EmployeeVM emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _businessInterface.InsertEmployee(emp);
            return View(result);
        }*/
    }
}