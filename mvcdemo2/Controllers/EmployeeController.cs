using mvcdemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo2.Controllers
{
    public class EmployeeController : Controller
    {
       
        //
        // GET: /Employee/
        public ActionResult Index()
        {
           var employeeList = new List<Employee> { 
            new Employee{Id=1,Name="Aman KUmar",Age=27},
            new Employee{Id=2,Name="Anil KUmar ",Age=31},
            new Employee{Id=3,Name="Vikas",Age=23},
            new Employee{Id=4,Name="Amit KUmar ",Age=20}           
            };

           
            return View(employeeList);
        }

        public ActionResult Edit(int id,string name)
        {
            var emp = new Employee { Id = 2, Name = "Anil KUmar", Age = 31 };
            return View(emp);
        }
        public ActionResult Delete(int id)
        {
            
            return View();
        }
	}
}