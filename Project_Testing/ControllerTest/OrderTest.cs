using FakeItEasy;
using Marcos_Pizza.Controllers;
using Marcos_Pizza.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Testing.ControllerTest
{
   
    public  class  OrderTest
    {
        private OrdersController ordersController;
        ordersController = A.Fake<OrdersController>();
    }
}
