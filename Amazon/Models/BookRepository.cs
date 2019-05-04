﻿using Amazon.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class BookRepository
    {
        public static List<Book> books = new List<Book>();
        public static IEnumerable<Book> Books//para acceder a books
        {
            get
            {
                return books;
            }
        }
        public static void AddResponse(Book book)
        {
            books.Add(book);
        }
        public static List<Book> FillBooks()
        {
          if (!books.Any()) //ANY verifica si contiene elementos
          {
            Book book1 = new Book()
            {
                ISBN = "123456789",
                Author = "Giancarlo G",
                NroPages = 210, Price = 270,
                Title = "How to Program ASP.NET MVC"
            };
            Book book2 = new Book()
            {
                ISBN = "521648597",
                Author = "Giancarlo G",
                NroPages = 3200,
                Price = 3000,
                Title = "How to Program C#"
            };
            Book book3 = new Book()
            {
                ISBN = "5365648597",
                Author = "carlo G",
                NroPages = 3200,
                Price = 3000,
                Title = "How to Program C#",
                LevelStock = LevelStock.SoldOut
            };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(null);
          }
            return books;
        }
        public static decimal TotalPrice()
        {
            return books.TotalPriceExtension();
            /*decimal? acum = 0;
            foreach (var item in books)
            {
                acum = acum + item.Price;
            }
            return acum;*/
        }
        public static IEnumerable<Book> FilterBookByPagesRatherThan(int nroPages)
        {
            return books.FilterByNroPagesGreaterThan(nroPages);
        }
    }
}