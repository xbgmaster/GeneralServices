using GeneralServices.Entities;

namespace GeneralServices.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<GeneralServiceUser?> GetUserAsync(string username, string password);
    }
}