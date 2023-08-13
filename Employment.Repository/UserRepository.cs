using Employment.Repository.Entities;
using Employment.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

namespace Employment.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiContext context;

        public UserRepository(ApiContext context)
        {
            this.context = context;
        }

        public async Task<User> Get(int id)
        {
            var user = await context.User
                .AsNoTracking()
                .Include(u => u.Address)
                .Include(u => u.Employments)
                .FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<bool> IsEmailUnique(string email, int? id = null)
        {
            return !await context.User.AnyAsync(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase) && u.Id != (id ?? 0));
        }

        public async Task<bool> IsExisting(int id)
        {
            return await context.User.AnyAsync(u => u.Id == id);
        }

        public async Task Post(User user)
        {
            await context.User.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task Put(User user, List<Entities.Employment> employmentsToDelete)
        {
            context.Attach(user);
            context.Entry(user).State = EntityState.Modified;

            context.Employment.RemoveRange(employmentsToDelete);

            await context.SaveChangesAsync();
        }
    }
}
