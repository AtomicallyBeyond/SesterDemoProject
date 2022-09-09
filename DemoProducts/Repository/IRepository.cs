using DemoProducts.Data;

namespace DemoProducts.Repository;

public interface ICustomerRepository
{
    public Task<CustomerDto> Create(CustomerDto objDto);
    
    public Task<int> Update(CustomerDto objDto);
    
    public Task<int> Delete(int id);

    public Task<CustomerDto> Get(int id);

    public Task<IEnumerable<CustomerDto>> GetAll();
}