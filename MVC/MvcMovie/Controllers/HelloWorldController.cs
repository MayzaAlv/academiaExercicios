using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Minha ação padrão";
        }

        public string Welcome(string nome, int vezes = 1)
        {
            return HtmlEncoder.Default.Encode($"oi {nome}, vezes: {vezes}");
        }
    }
}
