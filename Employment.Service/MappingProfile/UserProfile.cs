using AutoMapper;
using Employment.Domain.Dto.User;
using Employment.Repository.Entities;

namespace Employment.Service.MappingProfile
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GetResponseDto>()
                .ForMember(dest => dest.Address,
                opts => opts.MapFrom(src => src.Address))
                .ForMember(dest => dest.Employments,
                opts => opts.MapFrom(src => src.Employments));

            CreateMap<PostRequestDto, User>()
                .ForMember(dest => dest.Address,
                opts => opts.MapFrom(src => src.Address))
                .ForMember(dest => dest.Employments,
                opts => opts.MapFrom(src => src.Employments));

            CreateMap<PutRequestDto, User>()
                .ForMember(dest => dest.Address,
                opts => opts.MapFrom(src => src.Address))
                .ForMember(dest => dest.Employments,
                opts => opts.MapFrom(src => src.Employments));
        }
    }
}
