using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMath.Api.Models;
using SimpleMath.Core;

namespace SimpleMath.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Sum(Numbers numbers)
        {
            var sum = Calculator.Add(numbers.First, numbers.Second);
            return Json(sum);
        }

        public ActionResult Diff(Numbers numbers)
        {
            var retVal = Calculator.Subtract(numbers.First, numbers.Second);
            return Json(retVal);
        }

        public ActionResult Multiply(Numbers numbers)
        {
            var retVal = Calculator.Mult(numbers.First, numbers.Second);
            return Json(retVal);
        }
    }
}
