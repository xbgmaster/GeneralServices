using GeneralServices.Repositories.Interfaces;
using GeneralServices.Services.Interfaces;

namespace GeneralServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> ValidateUserAsync(string username, string password)
        {
            var user = await _repository.GetUserAsync(username, password);
            return user != null;
        }
    }
}