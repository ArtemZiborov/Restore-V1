using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(StoreContext context) : ControllerBase
    {
        [HttpGet]
        //Using async methods for database queries
        public async Task <ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();//all querry get returned as a list. making call to our database
        }

        [HttpGet("{id}")]
        //Using async methods for database queries
        public async Task <ActionResult<Product>> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);//making call to our database

            if(product == null) return NotFound();

            return product;
        
        }
    }
}
