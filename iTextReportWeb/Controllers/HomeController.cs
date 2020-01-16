using iTextReportWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iTextReportWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListPerson()
        {
            try
            {
                List<PersonModels> lista = new List<PersonModels>()
                {
                    new PersonModels{ PersonID = 1 , FirstName = "Nombre 1", LastName= "Last name 1", Cv= "file.pdf"},
                    new PersonModels{ PersonID = 2, FirstName = "Nombre 2", LastName= "Last name 1", Cv= "file.pdf"},
                    new PersonModels{ PersonID = 3 , FirstName = "Nombre 3", LastName= "Last name 1", Cv= "file.pdf"},
                };

                return Json(lista,JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}