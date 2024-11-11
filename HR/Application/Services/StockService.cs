using HR.Application.Ports;
using HR.Domain.Entities;

namespace HR.Application.Services;

public class StockService : IStockService
{
    private readonly IStockRepository stockRepository;

    public StockService(IStockRepository stockRepository)
    {
        this.stockRepository = stockRepository;
    }

    public List<Stock> GetAll()
    {
        return stockRepository.GetAll();
    }

    public Stock GetById(int id)
    {
        return stockRepository.GetById(id);
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
