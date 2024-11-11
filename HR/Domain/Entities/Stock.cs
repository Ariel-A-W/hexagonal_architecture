using HR.Domain.ValueObjects;

namespace HR.Domain.Entities;

public class Stock
{
    public Id? Id { get; set; }
    public Producto? Producto { get; set; }
    public Cantidad? Cantidad { get; set; } 
    public IVA? IVA { get; set; }
    public Precio? Precio { get; set; }
    public PrecioMasIVA? PrecioMasIVA { get; set; }
}
