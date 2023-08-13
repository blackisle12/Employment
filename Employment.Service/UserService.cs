using AutoMapper;
using Employment.Domain.Dto.User;
using Employment.Repository.Entities;
using Employment.Repository.Interface;
using Employment.Service.Interface;
using System.Text;

namespace Employment.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;

        public UserService(
            IUserRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<GetResponseDto> Get(int id)
        {
            var user = await repository.Get(id);

            return mapper.Map<GetResponseDto>(user);
        }

        public async Task Post(PostRequestDto request)
        {
            var errors = new StringBuilder();

            if (!await repository.IsEmailUnique(request.Email))
            {
                errors.AppendLine($"Email {request.Email} is already used.");
            }

            if (request.Employments != null)
            {
                request.Employments
                    .ForEach(e =>
                {
                    if (e.EndDate != null && e.EndDate <= e.StartDate)
                    {
                        errors.AppendLine($"End date should be higher than Start date for employment on company {e.Company}");
                    }
                });
            }

            if (errors.Length > 0) throw new ArgumentException(errors.ToString());

            var user = mapper.Map<User>(request);

            await repository.Post(user);
        }

        public async Task Put(PutRequestDto request)
        {
            var errors = new StringBuilder();

            if (!await repository.IsExisting(request.Id))
            {
                errors.AppendLine($"User with id {request.Id} does not exists.");
            }

            if (!await repository.IsEmailUnique(request.Email, request.Id))
            {
                errors.AppendLine($"Email {request.Email} is already used.");
            }

            if (request.Employments != null)
            {
                request.Employments
                    .ForEach(e =>
                    {
                        if (e.EndDate != null && e.EndDate <= e.StartDate && !e.IsDeleted)
                        {
                            errors.AppendLine($"End date should be higher than Start date for employment on company {e.Company}");
                        }
                    });
            }

            if (errors.Length > 0) throw new ArgumentException(errors.ToString());

            var user = mapper.Map<User>(request);
            user.Employments = mapper.Map<List<Repository.Entities.Employment>>(request.Employments?.Where(e => !e.IsDeleted).ToList());

            await repository.Put(
                user,
                employmentsToDelete: mapper.Map<List<Repository.Entities.Employment>>(request.Employments?.Where(e => e.IsDeleted).ToList()));
        }
    }
}
