using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class Calculadora : Controller
{
    public IActionResult Operacao()
    {
        return View();
    }

    public IActionResult Resultado(double n1, double n2, string option)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Option = option;

        switch (option)
        {
            case "soma":
                ViewBag.Resultado = n1 + n2;
                ViewBag.Sinal = "+";
            break;
            case "subtração":
                ViewBag.Resultado = n1 - n2;
                ViewBag.Sinal = "-";
            break;
            case "multiplicação":
                ViewBag.Resultado = n1 * n2;
                ViewBag.Sinal = "*";
            break;
            case "divisão":
                ViewBag.Resultado = n1 / n2;
                ViewBag.Sinal = "/";
            break;
        }

        return View();
    }
}