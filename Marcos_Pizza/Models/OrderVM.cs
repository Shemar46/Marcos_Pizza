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
        public int? Order_Id { get; set; }
        [ForeignKey("User")]
        public string? User_Id { get; set; }
        public String? Payment_Method { get; set; }
        // public string Time_Created { get; set;}
        public DateTime Datetime_Created { get; set; }
        public float Cost { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
    }
}
