using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() //ingresa a la clse principal invocando INDEX
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView"); // que vista quieres mostrar a VIEWS / HOME/ INDEX
        }

        [HttpGet]
        public ViewResult RegBookForm()
        {
            return View();
        }

        [HttpPost] //enviar datos que alteren la informacion (LIKE)
        public ViewResult RegBookForm(Book book)
        {
            if (ModelState.IsValid)
            {
                BookRepository.AddResponse(book);
                return View("Thanks", book);
            }
            else
            { // Hay un error de validación y retornamos una vista en blanco. 
                return View();
            }
        }
        [HttpGet]
        public ViewResult ListResponses()
        { //return View(BookRepository.Books.Where(b => b.Price > 100)); Libros caros 
          //return View(BookRepository.Books.Where(b => b.Price < 100)); Libros baratos
            return View(BookRepository.Books);
        }

            public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
