namespace HR.Infrastructure.Adapters.Messages;

public interface IStockMessage
{
    public void Information(string message);
    public void Warning(string message);
    public void Error(string message);
}
