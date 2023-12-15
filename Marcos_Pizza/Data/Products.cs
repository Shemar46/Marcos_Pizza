using System.ComponentModel.DataAnnotations;

namespace Marcos_Pizza.Data
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name Of Product")]
        public string Product_Name { get; set; }
        [Display(Name = "Description Of Product")]
        public string Product_Description { get; set;}
        [Display(Name = "Cost")]
        public float Product_Cost { get; set;}
        [Display(Name = "Code")]
        public int? Product_Code { get; set;} 
        public string? Product_IMG { get; set;}  
    }
}
