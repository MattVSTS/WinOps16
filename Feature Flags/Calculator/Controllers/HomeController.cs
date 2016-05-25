using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Calculator.Models;
namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(double? firstNumber, double? secondNumber)
        {
            if (firstNumber.HasValue && secondNumber.HasValue)
            {
                double result = firstNumber.Value + secondNumber.Value;

                this.ViewBag.firstNumber = firstNumber.ToString();
                this.ViewBag.secondNumber = secondNumber.ToString();
                this.ViewBag.Sum = result.ToString();

                return this.View();
            }

            this.ViewBag.Sum = this.ViewBag.firstNumber = this.ViewBag.secondNumber = 0;
            return this.View();
        }

        public ActionResult Subtract(double? firstNumber, double? secondNumber)
        {
            if (firstNumber.HasValue && secondNumber.HasValue)
            {
                double result = firstNumber.Value - secondNumber.Value;

                this.ViewBag.firstNumber = firstNumber.ToString();
                this.ViewBag.secondNumber = secondNumber.ToString();
                this.ViewBag.Subtract = result.ToString();

                return this.View();
            }

            this.ViewBag.Subtract = this.ViewBag.firstNumber = this.ViewBag.secondNumber = 0;
            return this.View();
        }
    }
}