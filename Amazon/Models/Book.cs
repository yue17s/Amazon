﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Amazon.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        [Required(ErrorMessage ="Porfavor ingresa un ISBN")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un titulo")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Precio")]
        // EL signo ? es para poner NULL el campo
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Porfavor ingresa un Nro de Paginas")]
        public int? NroPages { get; set; }
        public LevelStock LevelStock { get; set; } = LevelStock.InStock;
    }
}
