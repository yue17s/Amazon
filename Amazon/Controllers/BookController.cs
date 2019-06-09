using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;
using Amazon.Models.Extensions;
using Amazon.Models.ViewModels;

namespace Amazon.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int PageSize = 4;
        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int bookPage = 1)
        {
            var bookListViewModel = new BooksListViewModel
            {
                Books = repository.Books
                /*.Where(bo => bo.NroPages == 200)*/
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.Price)
                .Skip((bookPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = bookPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Books.Count()
                },
                CurrentCategory = category
            };
            return View(bookListViewModel);
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