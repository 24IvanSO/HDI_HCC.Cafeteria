using HDI_HCC.Cafeteria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HDI_HCC.Cafeteria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tb_HccProductosController : ControllerBase
    {
        private readonly Tb_HccProductos_Context _context;
        public Tb_HccProductosController(Tb_HccProductos_Context context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AgregarProducto")]
        public async Task<IActionResult>AgregarProducto(Tb_HccProductos tb_HccProductos)
        {
            await _context.Tb_HccProductos.AddAsync(tb_HccProductos);
            await   _context.SaveChangesAsync();

            return Ok();
        }
    }
}
