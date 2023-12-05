using System.ComponentModel.DataAnnotations.Schema;

namespace Marcos_Pizza.Data
{
    public class Orders
    {

        public int Id { get; set; } 
        public int Order_Id{ get; set;}
        [ForeignKey ("User") ]
        public string User_Id { get; set;}
        public  String? Payment_Method {get; set;} 
       // public string Time_Created { get; set;}
        public string Datetime_Created { get; set;}
        public float Cost { get; set;}  


       
    }
}
