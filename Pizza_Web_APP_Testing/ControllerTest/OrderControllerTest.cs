using AutoMapper;
using FakeItEasy;
using Marcos_Pizza.Controllers;
using Marcos_Pizza.Data;
using Marcos_Pizza.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizza_Web_APP_Testing.ControllerTest
{
   public class OrderControllerTest
    {
        private OrderVM ordersVM;
        private ProductVM productVM;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrderControllerTest(ApplicationDbContext context, IMapper mapper) 
        {
            ordersVM = A.Fake<OrderVM>();
            productVM = A.Fake<ProductVM>();
            _context = context;
            _mapper= mapper;

            
        }

        [Fact]
        public int Create_ReturnsAViewResult_WithOrderVM()
        {
            //Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var testId = 1;
            var testProduct = new Products { Id = testId, Product_Cost = 100, Product_Name = "Test", Product_Description = "Test Description" };
            mockContext.Setup(ctx => ctx.Products.FirstOrDefault(m => m.Id == testId)).Returns(testProduct);
            var controller = new OrdersController(mockContext.Object, _mapper);

            //Act
             var result = controller.Create(testId);
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<OrderVM>(viewResult.ViewData.Model);
            Assert.Equal(testProduct.Product_Cost, model.Cost);
            Assert.Equal(testProduct.Product_Name, model.Product_Name);
            Assert.Equal(testProduct.Product_Description, model.Product_Description);

            return 0;
        }
    }
}
