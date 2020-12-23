using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskWebApi.Domain.Core;
using TestTaskWebApi.Domain.Interfaces;

namespace TestTaskWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        IOrderRepository orderRep;
        public OrderController(IOrderRepository order)
        {
            this.orderRep = order;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return Ok(orderRep.GetOrders());
        }
        [HttpGet("{clientId}")]
        public ActionResult<IEnumerable<Order>> Get(int clientId)
        {
            IEnumerable<Order> orders = orderRep.GetOrders(clientId);
            return Ok(orders);
        }
        [HttpGet("{year}/{mounth}/{day}")]
        public ActionResult<IEnumerable<Order>> Get(int year, int mounth, int day)
        {
            if ((mounth < 0 || mounth > 12) || (day < 0 || day > 31))
            {
                return BadRequest();
            }
            DateTime dateTime = new DateTime(year, mounth, day);
            IEnumerable<Order> orders = orderRep.GetOrders(dateTime);
            return Ok(orders);
        }
    }
}
