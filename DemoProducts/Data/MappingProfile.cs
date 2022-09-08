using AutoMapper;
using DemoProducts.Data;

namespace DemoProducts.Repository;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Customer, CustomerDto>().ReverseMap();
    }
}