using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers
{
    public class CalcularController : Controller
    {
        //
        // GET: /Calcular/

        public ActionResult Index()
        {
            ViewBag.hora = DateTime.Now.ToString();
            ViewBag.msn = "Tiempo del Servidor: ";
            return View();
        }
        public ActionResult Suma(Calcular s)
        {
            if (ModelState.IsValid)
            {
                ViewBag.r = "La SUMA es: " + (s.num1 + s.num2).ToString();
                return this.View();
            }
            return View();
        }
        public ActionResult Resta(Calcular r)
        {
            if (ModelState.IsValid)
            {
                ViewBag.r = "La RESTA es: " + (r.num1 - r.num2).ToString();
                return this.View();
            }
            return View();
        }
        public ActionResult Multiplicacion(Calcular m)
        {
            if (ModelState.IsValid)
            {
                ViewBag.r = "La MULTIPLICACION es: " + (m.num1 * m.num2).ToString();
                return this.View();
            }
            return View();
        }
        public ActionResult Division(Calcular d)
        {
            if (ModelState.IsValid)
            {
                if (d.num2 == 0)
                {
                    ViewBag.r = "ERROR...El denominador no puede ser 0 (cero)...";
                }
                else
                {
                    ViewBag.r = "La DIVISION es: " + (d.num1 / d.num2).ToString();
                    return this.View();
                }
            }
            return View();
        }
    }
}
