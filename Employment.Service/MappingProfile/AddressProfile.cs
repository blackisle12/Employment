using AutoMapper;
using Employment.Domain.Dto.User;
using Employment.Repository.Entities;

namespace Employment.Service.MappingProfile
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, GetAddressResponseDto>();
            CreateMap<PostAddressRequestDto, Address>();
            CreateMap<PutAddressRequestDto, Address>();
        }
    }
}
