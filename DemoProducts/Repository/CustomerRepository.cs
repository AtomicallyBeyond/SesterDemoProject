using AutoMapper;
using DemoProducts.Data;

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

    public CustomerDto Create(CustomerDto objDto)
    {
        var customer = _mapper.Map<CustomerDto, Customer>(objDto);

        _db.Customers.Add(customer);
        _db.SaveChanges();

        return _mapper.Map<Customer, CustomerDto>(customer);
    }

    public int Update(CustomerDto objDto)
    {
        var customer = _mapper.Map<CustomerDto, Customer>(objDto);

        _db.Customers.Update(customer);
        return _db.SaveChanges();
    }

    public int Delete(int id)
    {
        var obj = _db.Customers.FirstOrDefault(u => u.Id == id);

        if (obj != null)
        {
            _db.Customers.Remove(obj);
            return _db.SaveChanges();
        }
        return 0;
    }

    public CustomerDto Get(int id)
    {
        var obj = _db.Customers.FirstOrDefault(u => u.Id == id);

        if (obj != null)
        {
            return _mapper.Map<Customer, CustomerDto>(obj);
        }

        return new CustomerDto();
    }

    public IEnumerable<CustomerDto> GetAll()
    {
        return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(_db.Customers);
    }
}