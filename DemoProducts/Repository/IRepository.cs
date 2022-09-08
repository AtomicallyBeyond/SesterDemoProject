using DemoProducts.Data;

namespace DemoProducts.Repository;

public interface ICustomerRepository
{
    public CustomerDto Create(CustomerDto objDto);
    
    public int Update(CustomerDto objDto);
    
    public int Delete(int id);

    public CustomerDto Get(int id);

    public IEnumerable<CustomerDto> GetAll();
}