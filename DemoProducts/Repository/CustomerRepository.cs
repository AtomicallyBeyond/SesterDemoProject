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

    public async Task<CustomerDto> CreateAsync(CustomerDto objDto)
    {
        var customer = _mapper.Map<CustomerDto, Customer>(objDto);

        var addedCustomer = _db.Customers.Add(customer);
        await _db.SaveChangesAsync();

        return _mapper.Map<Customer, CustomerDto>(addedCustomer.Entity);
    }

    public async Task<int> UpdateAsync(CustomerDto objDto)
    {
        var objFromDb = await _db.Customers.FirstOrDefaultAsync(u => u.Id == objDto.Id);
        
        if (objFromDb == null)
            return 0;
        
        objFromDb.CompanyName = objDto.CompanyName;
        objFromDb.ContactName = objDto.ContactName;
        objFromDb.PhoneNumber = objDto.PhoneNumber;
        objFromDb.EmailAddress = objDto.EmailAddress;
        objFromDb.Street = objDto.Street;
        objFromDb.City = objDto.City;
        objFromDb.State = objDto.State;
        objFromDb.ZipCode = objDto.ZipCode;
        objFromDb.CustomerNotes = objDto.CustomerNotes;
        _db.Customers.Update(objFromDb);
        return await _db.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(int id)
    {
        var obj = await _db.Customers.FirstOrDefaultAsync(u => u.Id == id);

        if (obj == null)
            return 0;
        
        _db.Customers.Remove(obj);
        return await _db.SaveChangesAsync();
    }

    public async Task<CustomerDto> GetAsync(int id)
    {
        var obj = await _db.Customers.FirstOrDefaultAsync(u => u.Id == id);

        if (obj == null)
            return new CustomerDto();
        
        return _mapper.Map<Customer, CustomerDto>(obj);
    }

    public async Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(_db.Customers);
    }
}