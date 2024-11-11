using HR.Application.Ports;
using HR.WebAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HR.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stock;

        public StockController(IStockService stock)
        {
            _stock = stock;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StockResponseDTO>> Get()
        {
            List<StockResponseDTO> outLstStock = new();

            if (_stock.GetAll().Count == 0)
                return NotFound("No se hallan registros.");

            foreach (var item in _stock.GetAll())
            {
                outLstStock.Add(
                   new StockResponseDTO() 
                   { 
                       Id = item.Id!.Value, 
                       Producto = item.Producto!.Value, 
                       Cantidad = item.Cantidad!.Value, 
                       Precio = item.Precio!.Value,
                       IVA = item.IVA!.Value, 
                       PrecioMasIVA = 
                            item.PrecioMasIVA!.GetPrecioMasIVA()
                   }
                );
            }        
            
            return Ok(outLstStock);
        }

        [HttpGet("getbyid")]
        public ActionResult<StockResponseDTO> GetById(int id)
        { 
            var item = _stock.GetById(id);

            if (item == null)
                return NotFound("El registro no existe.");

            var outStock = new StockResponseDTO()
            {
                Id = item.Id!.Value,
                Producto = item.Producto!.Value,
                Cantidad = item.Cantidad!.Value,
                Precio = item.Precio!.Value,
                IVA = item.IVA!.Value,
                PrecioMasIVA =
                      item.PrecioMasIVA!.GetPrecioMasIVA()
            };

            return Ok(outStock);
        }
    }
}
