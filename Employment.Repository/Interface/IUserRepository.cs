using Employment.Repository.Entities;

namespace Employment.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
        Task<bool> IsEmailUnique(string email, int? id = null);
        Task<bool> IsExisting(int id);
        Task Post(User user);
        Task Put(User user, List<Entities.Employment> employmentsToDelete);
    }
}
