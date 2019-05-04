using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;
using Amazon.Models.Extensions;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() //ingresa a la clse principal invocando INDEX
        {
            BookRepository.FillBooks();
            return View("Index"); // que vista quieres mostrar a VIEWS / HOME/ INDEX
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
            IEnumerable<Book> books = BookRepository.FilterBookByPagesRatherThan(250);
            decimal TotalPrice = books.TotalPriceExtension();
            ViewBag.TotalPrice = TotalPrice;
            return View(books);
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
    }
}
