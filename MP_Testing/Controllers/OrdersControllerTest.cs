using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Marcos_Pizza.Controllers;
using Marcos_Pizza.Data;
using Marcos_Pizza.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_Testing.Controllers
{
    
    public class OrdersControllerTest
    {
        private OrdersController _ordersController;
        private Orders orders;
        private Products products;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private IHttpContextAccessor _httpcontextAccessor;
        public OrdersControllerTest() 
        {
            //Dependemcies
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().Options;
            orders =  A.Fake<Orders>();    
            products = A.Fake<Products>();
            _httpcontextAccessor = A.Fake<HttpContextAccessor>(); 
            _mapper = A.Fake<IMapper>();
            // _context = new A.Fake<ApplicationDbContext>(options);

            _context = new ApplicationDbContext(options);


            //SUT
            _ordersController = new OrdersController(_context,_mapper);

        }

        [Fact]
        public void OrderController_Index()
        {
            // Arrange
            var Orders = A.Fake<IEnumerable<Orders>>();
            A.CallTo(() => Orders.ToString());
            //ACT
            var result = _ordersController.Index();
            //Assert
            result.Should().BeOfType<Task<IActionResult>>();
        }
        [Fact]
        public void OrderController_Detail()
        {
            // Arrange
            int id = 1;
            //var Orders = A.Fake<Orders>();
            //A.CallTo(() => Orders.ToString());
            //ACT
            var result = _ordersController.Details(id);
            //Assert
            result.Should().BeOfType<Task<IActionResult>>();
        }
        
        
        [Fact]
        public void OrderController_Delete()
        {
            // Arrange
            int id = 1;
            //ACT
            var result = _ordersController.Delete(id);
            //Assert
            result.Should().BeOfType<Task<IActionResult>>();
        }
    }




} 
