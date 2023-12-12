using System.ComponentModel.DataAnnotations;

namespace Marcos_Pizza.Data
{
    public class Products
    {
        [Key]
        public int Id { get; set; } 
        public string Product_Name { get; set; }
        public string Product_Description { get; set;}
        public float Product_Cost { get; set;} 
        public int Product_Code { get; set;} 
        public string Product_IMG { get; set;}  
    }
}
