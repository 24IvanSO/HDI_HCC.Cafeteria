using HDI_HCC.Cafeteria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HDI_HCC.Cafeteria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tb_HccOrdenesController : ControllerBase
    {
        private readonly Tb_HccOrdenes_Context _context;
        public Tb_HccOrdenesController(Tb_HccOrdenes_Context context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AgregarOrden")]
        public async Task<IActionResult> AgregarOrden(Tb_HccOrdenes tb_HccOrdenes)
        {
            await _context.Tb_HccOrdenes.AddAsync(tb_HccOrdenes);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        [Route("OrdenesTotales")]
        public async Task<IActionResult> VerOrdenes([FromQuery] Tb_HccOrdenes tb_HccOrdenes)
        {
            var ordenes = await _context.Tb_HccOrdenes.ToListAsync();
            return Ok(ordenes);
        }
        [HttpGet]
        [Route("OrdenesPorMesa")]
        public async Task<IActionResult> VerOrdenesPorMesa(int mes_id)
        {
            var ordenes = await _context.Tb_HccOrdenes.FindAsync(mes_id);
            if (ordenes == null)
            {
                return NotFound();
            }
            return Ok(ordenes);
        }
        [HttpPut]
        [Route("ActualizarEstatusOrden")]
        public async Task<IActionResult> ActualizarEstatusOrden(int ord_id, int catord_id, Tb_HccOrdenes tb_HccOrdenes)
        {
            var ordenEst = await _context.Tb_HccOrdenes.FindAsync(ord_id, catord_id);
            if (ordenEst == null)
            {
                return NotFound();
            }
            ordenEst.catord_id = tb_HccOrdenes.catord_id;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        [Route("EliminarOrden")]
        public async Task<IActionResult> EliminarOrden(int ord_id, int ord_estatus, Tb_HccOrdenes tb_HccOrdenes)
        {
            var ordenElim = await _context.Tb_HccOrdenes.FindAsync(ord_id, ord_estatus);
            if (ordenElim == null)
            {
                return NotFound();
            }
            ordenElim.ord_estatus = tb_HccOrdenes.ord_estatus;

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
