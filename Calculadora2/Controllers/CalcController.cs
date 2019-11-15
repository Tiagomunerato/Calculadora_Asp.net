using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result()
        {
            int n1 = int.Parse(Request["txtNumero1"]);
            int n2 = int.Parse(Request["txtNumero2"]);
            string botao = Request["Calcular"];

            if (botao == "+")
            {
                int resultado = n1 + n2;
                ViewBag.Resultado = resultado;
            }
            if (botao == "-")
            {
                int resultado = n1 - n2;
                ViewBag.Resultado = resultado;
            }
            if (botao == "*")
            {
                int resultado = n1 * n2;
                ViewBag.Resulatdo = resultado;
            }
            if (botao == "/")
            {


                double resultado = n1 / n2;
                ViewBag.Resultado = resultado;
            }



            return View();
        }
    }
}