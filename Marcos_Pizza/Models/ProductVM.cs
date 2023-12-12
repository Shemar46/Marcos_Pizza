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
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public float Product_Cost { get; set; }
        public int Product_Code { get; set; }
        public string Product_IMG { get; set; }
    }
}
