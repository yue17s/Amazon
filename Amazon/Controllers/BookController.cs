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
    public class BookController : Controller
    {
        private IBookRepository repository;
        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Books);
        }

        /* public IRepository repository = BookRepository.SharedRepository;
         [HttpGet]
         public IActionResult Index() //ingresa a la clse principal invocando INDEX
         {
             return View("Index", repository.Books); // que vista quieres mostrar a VIEWS / HOME/ INDEX
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
                 repository.AddBook(book);
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
             IEnumerable<Book> books = repository.Books.FilterByNroPagesGreaterThan(0);
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
         }*/
    }
}