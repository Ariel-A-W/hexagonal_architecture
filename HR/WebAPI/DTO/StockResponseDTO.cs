namespace HR.WebAPI.DTO;

public class StockResponseDTO
{
    public int Id { get; set; }
    public string? Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal IVA { get; set; }
    public decimal Precio { get; set; }
    public decimal PrecioMasIVA { get; set; }
}
