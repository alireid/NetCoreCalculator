using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreCalculator.Models;

namespace NetCoreCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Operation model)
        {
            model.Result = model.OperationType switch
            {
                OperationType.Addition => model.NumberA + model.NumberB,
                OperationType.Multiplication => model.NumberA * model.NumberB,
                OperationType.Division => model.NumberA / model.NumberB,
                OperationType.Subtraction => model.NumberA - model.NumberB,
                _ => 0,
            };
            return View(model);
        }
    }
}