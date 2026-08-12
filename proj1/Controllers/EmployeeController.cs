using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proj1.Models;

namespace proj1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //Employee em = new Employee {Empid="E147",Name="Satya",age=19};
            List<Employee> ll = new List<Employee>
            {
                new Employee {Empid="E147",Name="Satya",age=19},
                new Employee {Empid="E149",Name="vardhan",age=20}
            };

            return View(ll);
        }
    }
}