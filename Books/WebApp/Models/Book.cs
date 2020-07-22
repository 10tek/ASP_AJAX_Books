using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        [Display(Name = "Название книги")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Стоимость")]
        public decimal Price { get; set; }
    }
}
