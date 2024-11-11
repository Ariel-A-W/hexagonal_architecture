using HR.Application.Ports;
using HR.Domain.Entities;
using HR.Domain.ValueObjects;
using HR.Infrastructure.Adapters.Messages;

namespace HR.Infrastructure.Adapters.Persistence;

public class StockRepository : IStockRepository
{
    private readonly IStockMessage _logger;

    // Lista de productos de Stock para la DEMO. 
    private List<Stock> _stocks = new([
        new Stock() { 
            Id = new Id(1), 
            Producto = new Producto("Tuerca R22"), 
            Cantidad = new Cantidad(200), 
            IVA = new IVA(21), 
            Precio = new Precio(2.45M), 
            PrecioMasIVA = new PrecioMasIVA(
                2.45M, 21
            )            
        },
        new Stock() {
            Id = new Id(2),
            Producto = new Producto("Arandelas A22"),
            Cantidad = new Cantidad(200),
            IVA = new IVA(21),
            Precio = new Precio(0.65M),
            PrecioMasIVA = new PrecioMasIVA(
                0.65M, 21
            )
        },
        new Stock() {
            Id = new Id(3),
            Producto = new Producto("Tornillo S22"),
            Cantidad = new Cantidad(200),
            IVA = new IVA(21),
            Precio = new Precio(3.78M),
            PrecioMasIVA = new PrecioMasIVA(
                2.45M, 21
            )
        },
        new Stock() {
            Id = new Id(4),
            Producto = new Producto("Grampa GR120-T"),
            Cantidad = new Cantidad(200),
            IVA = new IVA(21),
            Precio = new Precio(23.63M),
            PrecioMasIVA = new PrecioMasIVA(
                23.63M, 21
            )
        }
    ]);

    public StockRepository(IStockMessage logger)
    {
        _logger = logger;
    }

    public List<Stock> GetAll()
    {
        try
        {
            _logger.Information("Listado completado.");
            return _stocks;
        }
        catch (Exception ex)
        {
            _logger.Error(
                String.Format(
                    "Se ha producido un error.",
                    ex.Message
                    )
                );
            return new List<Stock>();
        }
    }

    public Stock GetById(int id)
    {
        try
        {
            _logger.Information("Se ha filtrado satisfactoriamente.");
            return _stocks
                .FirstOrDefault(x => x.Id!.Value == id)!;
        }
        catch (Exception ex)
        {
            _logger.Error(
                String.Format(
                    "Se ha producido un error.", 
                    ex.Message
                    )
                );
            return new Stock();
        }
    }

    public int Add(Stock stock)
    {
        throw new NotImplementedException();
    }

    public int Delete(Stock stock)
    {
        throw new NotImplementedException();
    }

    public int Update(Stock stock)
    {
        throw new NotImplementedException();
    }
}
