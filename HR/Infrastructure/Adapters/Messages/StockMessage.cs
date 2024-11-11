namespace HR.Infrastructure.Adapters.Messages;

public class StockMessage : IStockMessage
{
    private readonly ILogger _logger;

    public StockMessage(ILogger<StockMessage> logger)
    {
        _logger = logger;
    }

    public void Error(string message)
    {        
        _logger.LogError(
            StampLogger("Error", message));
    }

    public void Information(string message)
    {        
        _logger.LogInformation(
            StampLogger("Information", message));
    }

    public void Warning(string message)
    {
        _logger.LogWarning(
            StampLogger("Warning", message));
    }

    private static string StampLogger(string flag, string message)
    {
        var guid = Guid.NewGuid().ToString().Substring(1, 7);
        var timeStamp = DateTime.UtcNow;
        var msj = String.Format(
            "#[{0}] [{1}] {2} => {3}", 
            guid, timeStamp, flag, message
        );
        return msj;
    }
}
