using GridDemo.Models.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridDemo.Controllers
{
    public class HomeController : Controller
    {

        DBModel db = new DBModel();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();            
        }
        
        public ActionResult GetAllEmployeeData()
        {
            return View(db.Employees.OrderBy(e => e.EmployeeId));     
        }

        public ActionResult GetAllEmployeeWithDetails()
        {
            return View(db.Employees.OrderBy(e => e.EmployeeId));
        }
        public ActionResult EmployeeDetail(int Id)
        {
            return View(db.Employees.Where(e => e.EmployeeId == Id).FirstOrDefault());
        }
	}
}