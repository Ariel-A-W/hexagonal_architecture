using HR.Domain.Exceptions;

namespace HR.Domain.ValueObjects;

public record Id(int Value);
public record Producto(string? Value)
{
    public string? GetProducto() =>
        Value!.Trim() != ""
        ? Value.Trim()
        : throw new StockException("No puede quedar vacío.");
}
public record Cantidad(int Value);
public record IVA(decimal Value);
public record Precio(decimal Value);
public record PrecioMasIVA(decimal Precio, decimal IVA)
{
    public decimal GetPrecioMasIVA() =>
        (decimal)Precio! + ((decimal)Precio * (decimal)IVA / 100);
}
