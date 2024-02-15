using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamroBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name ="List Price")]
        [Range(1,1000)]
        public Double ListPrice { get; set; }
        
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(1, 1000)]
        public Double Price { get; set; }
        
        [Required]
        [Display(Name = "Price of 50+")]
        [Range(1, 1000)]
        public Double Price50 { get; set; }
        
        [Required]
        [Display(Name = "Price of 100+")]
        [Range(1, 1000)]
        public Double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
