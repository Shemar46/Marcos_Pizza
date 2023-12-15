using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
// Add other necessary using directives

namespace Marcos_Pizza_Testing
{
    internal class OrdersTest
    {
        [Fact]
        public void Create_ReturnsAViewResult_WithOrderVM()
        {
            // Arrange
            var mockContext = new Mock<ApplicationDbContext>();
            var testId = 1;
            var testProduct = new Product { Id = testId, Product_Cost = 100, Product_Name = "Test", Product_Description = "Test Description" };
            mockContext.Setup(ctx => ctx.Products.FirstOrDefault(m => m.Id == testId)).Returns(testProduct);
            var controller = new OrderController(mockContext.Object);

            // Act
            var result = controller.Create(testId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<OrderVM>(viewResult.ViewData.Model);
            Assert.Equal(testProduct.Product_Cost, model.Cost);
            Assert.Equal(testProduct.Product_Name, model.Product_Name);
            Assert.Equal(testProduct.Product_Description, model.Product_Description);
        }
    }
}