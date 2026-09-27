using Microsoft.AspNetCore.Mvc;

namespace ConvTemp.Controllers
{
    public class TemperaturaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double temperatura, string conversao)
        {
            double resultado = 0;

            switch (conversao)
            {
                case "CelsiusFahrenheit":
                    resultado = (temperatura * 9 / 5) + 32;
                    break;

                case "CelsiusKelvin":
                    resultado = temperatura + 273.15;
                    break;

                case "FahrenheitCelsius":
                    resultado = (temperatura - 32) * 5 / 9;
                    break;

                case "FahrenheitKelvin":
                    resultado = ((temperatura - 32) * 5 / 9) + 273.15;
                    break;

                case "KelvinCelsius":
                    resultado = temperatura - 273.15;
                    break;

                case "KelvinFahrenheit":
                    resultado = ((temperatura - 273.15) * 9 / 5) + 32;
                    break;
            }

            ViewBag.Resultado = resultado;

            return View();
        }
    }
}