using Marcos_Pizza.Data;
using System.ComponentModel.DataAnnotations;

namespace Marcos_Pizza.Models
{
    public class ProductVM
    {
        public ProductVM()
        {
            Id = 0;
            Product_Cost = 0;
            Product_Name = "";
            Product_Description = "";
        }

        public ProductVM(Products products)
        {
           Id = products.Id;  
           Product_Cost = products.Product_Cost;
           Product_Name = products.Product_Name;
           Product_Description = products.Product_Description;
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Name Of Product")]
        public string Product_Name { get; set; }
        [Display(Name = "Description Of Product")]
        public string Product_Description { get; set; }
        [Display(Name = "Cost")]
        public float Product_Cost { get; set; }
        [Display(Name = "Code")]
        public int? Product_Code { get; set; }
        public string? Product_IMG { get; set; }
    }
}
