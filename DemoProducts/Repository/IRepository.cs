using DemoProducts.Data;

namespace DemoProducts.Repository;

public interface ICustomerRepository
{
    public Task<CustomerDto> CreateAsync(CustomerDto objDto);
    
    public Task<int> UpdateAsync(CustomerDto objDto);
    
    public Task<int> DeleteAsync(int id);

    public Task<CustomerDto> GetAsync(int id);

    public Task<IEnumerable<CustomerDto>> GetAllAsync();
}