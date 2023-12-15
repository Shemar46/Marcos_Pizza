using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Marcos_Pizza.Data;
using AutoMapper;
using Marcos_Pizza.Models;

namespace Marcos_Pizza.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrdersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
          //  string id = HttpContext.User.GetUserId();
            var Orders = _mapper.Map<List<OrderVM>>(await _context.Orders.ToListAsync());
            return View(Orders);


            //_context.Orders != null ? 
            //          View(await _context.Orders.ToListAsync()) :
            //          Problem("Entity set 'ApplicationDbContext.Orders'  is null.");
        }



        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: Orders/Create
        public IActionResult Create(int? ID)
        {
            
           var Products = _context.Products.FirstOrDefault(m=> m.Id == ID);

            string id = HttpContext.User.GetUserId();
            HttpContext.User.FindFirst(id);

            id = HttpContext.User.GetUserId();
            var User = _context.User.FirstOrDefault(f => f.Id == id);
            var orderVM = new OrderVM { Cost = Products.Product_Cost, Product_Name = Products.Product_Name, Product_Description = Products.Product_Description, Cashier_Name=User.FirstName };
           
            return View(orderVM);
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderVM orderVM, DateTime dateTime)
        {

          


            //orders.Product_Description = orderVM.Product_Description;
            //orders.Product_Name = orderVM.Product_Name;
            //orders.Datetime_Created =DateTime.Now;
            //orders.Cost = orderVM.Cost;


            if (ModelState.IsValid)
            {
                var orders = new Orders

                {
                    // orders.Product_Description = orderVM.Product_Description;
                    Product_Description = orderVM.Product_Name,
                    Datetime_Created = DateTime.Now,
                    Cost = orderVM.Cost

                };



                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(orderVM);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Order_Id,User_Id,Payment_Method,Datetime_Created,Cost")] Orders orders)
        {
            if (id != orders.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(orders.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orders);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Orders'  is null.");
            }
            var orders = await _context.Orders.FindAsync(id);
            if (orders != null)
            {
                _context.Orders.Remove(orders);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersExists(int id)
        {
          return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
