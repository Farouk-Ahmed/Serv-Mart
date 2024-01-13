using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.DTOs.ProductDTOs
{
    public class AddProductDTO
    {
        public string ProductName { get; set; }
        //[Required, StringLength(300, MinimumLength = 10)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, Provide a valid Product Price")]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Stoke { get; set; }
        [Required(ErrorMessage = "Please, Provide atleast one image")]
        //public ICollection<IFormFile> ProductMedias { get; set; }

        [Display(Name = "Choose Product Category")]
        public Guid CategoryID { get; set; }
        public string? ProviderId { get; set; }

        //public List<IFormFile>? Pics { get; set; } = new List<IFormFile>();
        public IFormFileCollection? Pics { get; set; }
    }
}
