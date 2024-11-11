using HR.Domain.Entities;

namespace HR.Application.Ports;

public interface IStockRepository
{
    public List<Stock> GetAll();
    public Stock GetById(int id);
    public int Add(Stock stock);
    public int Update(Stock stock);
    public int Delete(Stock stock);
}
