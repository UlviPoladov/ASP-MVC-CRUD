using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace WebApplication8.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ("Name is Required"))]

        [MinLength(3,ErrorMessage = "3 lenght min")]
        public string Name { get; set; }

        [Required(ErrorMessage =("Description Is Required"))]

        [MinLength(5, ErrorMessage = "5 lenght min")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "must be 1")]
        public int Discount { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "must be 1")]
        public int Price { get; set; }
        public string ImageLink { get; set; }

        public Product() 
        {
        
        }
        public Product(int ıd, string name, string description, int discount, int price, string ımageLink)
        {
            Id = ıd;
            Name = name;
            Description = description;
            Discount = discount;
            Price = price;
            ImageLink = ımageLink;
        }
    }
}
