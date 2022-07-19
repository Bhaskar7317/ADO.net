using ADO.NETCORE.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADO.NETCORE.Controllers
{
    public class HomeController : Controller
    {
        EmployeDataContext dataContext = new EmployeDataContext();
        public IActionResult Index()
        {
            var emps = dataContext.GetEmployees();
            return View(emps);
        }
    }
}
