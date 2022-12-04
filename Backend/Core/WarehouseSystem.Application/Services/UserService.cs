using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;

namespace WarehouseSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IAccountRepository _accountService;

        public UserService(IAccountRepository accountRepository)
        {
            _accountService = accountRepository;
        }

        public bool Authorize(string login, string password)
        {
            var result = _accountService.Authorize(login, password);
            return result;
        }

        public bool Registrate(string login, string password)
        {
            if (_accountService.UserExists(login, password))
                return false;

            var result = _accountService.Registrate(login, password);
            return result;
        }
    }
}
