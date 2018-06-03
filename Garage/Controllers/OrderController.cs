using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http.Description;
using Garage.Models;
using System.Web.Mvc;

namespace Garage.Controllers
{
    public class OrderController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: api/Orders
        public IQueryable<Order> GetOrders()
        {
            Order order = db.Orders
                .Include(c => c.OrderItems)
                .FirstOrDefault();

            OrderItem orderItem = db.OrderItems.FirstOrDefault();

            return db.Orders;
        }

        // GET: api/Orders/5
        [HttpGet]
        [ResponseType(typeof(Order))]
        public ActionResult GetOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                throw new Exception();
            }

            return View(order);
        }

        //// PUT: api/Orders/5
        //[ResponseType(typeof(void))]
        //public ActionResult PutOrder(int id, Order order)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != order.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(order).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrderExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Orders
        //[ResponseType(typeof(Order))]
        //public IHttpActionResult PostOrder()
        //{
        //    //Order order

        //    // Order order = new Order();
        //    //order.Id = 5;
        //    //order.DtCreate = DateTime.Now;
        //    //order.Comment = "Hello second world!";

        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return BadRequest(ModelState);
        //    //}

        //    Order order = db.Orders.FirstOrDefault();

        //    if (order.OrderItems == null)
        //    {
        //        order.OrderItems = new List<OrderItem>();
        //    }

        //    order.OrderItems.Add(
        //        new OrderItem() { Name = "Оклейка винилом" });

        //    //db.Orders.Add(order);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        //}

        //// DELETE: api/Orders/5
        //[ResponseType(typeof(Order))]
        //public IHttpActionResult DeleteOrder(int id)
        //{
        //    Order order = db.Orders.Find(id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Orders.Remove(order);
        //    db.SaveChanges();

        //    return Ok(order);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.Id == id) > 0;
        }
    }
}