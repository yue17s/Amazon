﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Amazon.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
