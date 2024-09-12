using GreenAppV2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GreenAppV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext database;

        public ProductsController(AppDbContext database)
        {
            this.database = database;
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            
            var product = await database.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

           
            database.Products.Remove(product);
            await database.SaveChangesAsync();

            return NoContent(); 
        }
        
        [HttpPost("{id}")]
        public async Task<IActionResult> 
    }
}
