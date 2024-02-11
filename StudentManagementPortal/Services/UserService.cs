using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;

namespace StudentManagementPortal.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User?> FindByEmailAsync(string email)
        {
            return await userRepository.FindByEmailAsync(email);
        }
    }
}
