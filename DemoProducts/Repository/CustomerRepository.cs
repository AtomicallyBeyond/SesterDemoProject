using AutoMapper;
using DemoProducts.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoProducts.Repository;


public class CustomerRepository : ICustomerRepository
{

    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public CustomerRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<CustomerDto> Create(CustomerDto objDto)
    {
        var customer = _mapper.Map<CustomerDto, Customer>(objDto);

        var addedCustomer = _db.Customers.Add(customer);
        await _db.SaveChangesAsync();

        return _mapper.Map<Customer, CustomerDto>(addedCustomer.Entity);
    }

    public async Task<int> Update(CustomerDto objDto)
    {
        var customer =  _mapper.Map<CustomerDto, Customer>(objDto);

        _db.Customers.Update(customer);
        return await _db.SaveChangesAsync();
    }

    public async Task<int> Delete(int id)
    {
        var obj = await _db.Customers.FirstOrDefaultAsync(u => u.Id == id);

        if (obj == null)
        {
            return 0;
        }
        _db.Customers.Remove(obj);
        return await _db.SaveChangesAsync();
    }

    public async Task<CustomerDto> Get(int id)
    {
        var obj = await _db.Customers.FirstOrDefaultAsync(u => u.Id == id);

        if (obj != null)
        {
            return _mapper.Map<Customer, CustomerDto>(obj);
        }

        return new CustomerDto();
    }

    public async Task<IEnumerable<CustomerDto>> GetAll()
    {
        return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(_db.Customers);
    }
}