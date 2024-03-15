using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes =1)
        {
            ViewData["Message"] = "Hello "+ name ;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        //Get: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        //Get: /HelloWorld/Welcome/
        //requieres using system.text.encodings.web
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is: {numTimes}");
        //}
    }
}
