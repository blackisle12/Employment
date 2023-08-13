using AutoMapper;
using Employment.Domain.Dto.User;

namespace Employment.Service.MappingProfile
{
    public class EmploymentProfile : Profile
    {
        public EmploymentProfile()
        {
            CreateMap<Repository.Entities.Employment, GetEmploymentResponseDto>();
            CreateMap<PostEmploymentRequestDto, Repository.Entities.Employment>();
            CreateMap<PutEmploymentRequestDto, Repository.Entities.Employment>();
        }
    }
}
