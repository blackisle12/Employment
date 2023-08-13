using Employment.Domain.Dto.User;

namespace Employment.Service.Interface
{
    public interface IUserService
    {
        Task<GetResponseDto> Get(int id);
        Task Post(PostRequestDto request);
        Task Put(PutRequestDto request);
    }
}
