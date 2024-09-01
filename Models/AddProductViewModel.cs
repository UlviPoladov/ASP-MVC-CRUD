using WebApplication8.Entities;
using Microsoft.AspNetCore.Http;

namespace WebApplication8.Models
{
    public class AddProductViewModel
    {
        public Product Product { get; set; }
        public IFormFile Image { get; set; }
        public AddProductViewModel()
        {

        }

    }
}