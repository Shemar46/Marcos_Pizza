using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marcos_Pizza.Models
{
    public class OrderVM
    {
        public OrderVM()
        {
           
            Cost = 0;
            Product_Description = string.Empty;
            Product_Name = string.Empty;    
        } 
        public OrderVM(OrderVM orderVM)
        {
              
            Cost = orderVM.Cost;    
            Product_Description= orderVM.Product_Description;
            Product_Name= orderVM.Product_Name;
        }

        public int Id { get; set; }
        //  public int Order_Id{ get; set;}
        [ForeignKey("User")]
        public string? User_Id { get; set; }
        [Display(Name = "Payment Method")]
        public String? Payment_Method { get; set; }
        // public string Time_Created { get; set;}
        public DateTime? Datetime_Created { get; set; }
        [Display(Name = "Cost")]
        [Required]
        public float Cost { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string Product_Name { get; set; }
        [Display(Name = "Description")]
        [Required]
        public string Product_Description { get; set; }

        [Display(Name = "Customer Name")]
        
        public string? Customer_Name { get; set; }

        [Display(Name = "Cashier Name")]
        
        public string? Cashier_Name { get; set; }
    }
}
