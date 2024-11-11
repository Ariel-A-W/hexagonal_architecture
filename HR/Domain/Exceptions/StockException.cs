namespace HR.Domain.Exceptions;

public class StockException : Exception
{
    public StockException() 
        : base("Se ha producido un error de Excepción genérico.") { }

    public StockException(string Message) : base(Message) { }
}
