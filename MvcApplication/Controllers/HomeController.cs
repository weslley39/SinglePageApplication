using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using MongoDB.Driver;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var mongoDb = MongoDatabase.Create(ConfigurationManager.AppSettings["MongoDBTimesheets"]);
            //var repository = mongoDb.GetCollection<Timesheet>(typeof(Timesheet).Name);
            //var timesheets = new List<Timesheet>
            //{
            //    new Timesheet { FirstName = "Weslley", LastName = "Neri", Month = 7, Year = 2013},
            //    new Timesheet { FirstName = "João", LastName = "Carlos", Month = 7, Year = 2013 }
            //};
            //foreach (var timesheet in timesheets)
            //    repository.Insert(timesheet);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
