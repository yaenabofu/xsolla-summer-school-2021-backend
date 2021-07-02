using Microsoft.AspNetCore.Mvc;
using RESTfulApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        readonly IProduct _context;

        public ProductController(IProduct context)
        {
            _context = context;
        }

        [Route("Get")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Get();
        }
        [Route("Get/ByPrice")]
        [HttpGet]
        public IEnumerable<Product> SortByPrice()
        {
            return _context.SortByPrice();
        }
        [Route("Get/ByType")]
        [HttpGet]
        public IEnumerable<Product> SortByType()
        {
            return _context.SortByType();
        }

        [Route("Get/{id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            Product todoItem = _context.Get(Id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return new ObjectResult(todoItem);
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create([FromBody] Product todoItem)
        {
            if (todoItem == null)
            {
                return BadRequest();
            }
            _context.Create(todoItem);

            return Ok();
        }

        [Route("Update/{id}")]
        [HttpPut]
        public IActionResult Update(int Id, [FromBody] Product updatedTodoItem)
        {
            if (updatedTodoItem == null || updatedTodoItem.Id != Id)
            {
                return BadRequest();
            }

            var item = _context.Get(Id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Update(updatedTodoItem);
            return Ok();
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var deletedTodoItem = _context.Delete(Id);

            if (deletedTodoItem == null)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
