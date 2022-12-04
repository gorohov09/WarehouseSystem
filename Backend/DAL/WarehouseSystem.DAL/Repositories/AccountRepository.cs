using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly WarehouseContext _warehouseContext;

        public AccountRepository(WarehouseContext warehouseContext)
        {
            _warehouseContext = warehouseContext;
        }

        public bool Authorize(string login, string password)
        {
            var result = _warehouseContext.Users.Any(x => x.Login == login && x.Password == password);
            return result;
        }

        public bool Registrate(string login, string password)
        {
            var user = new User
            {
                Login = login,
                Password = password
            };

            _warehouseContext.Users.Add(user);
            return _warehouseContext.SaveChanges() > 0;
        }

        public bool UserExists(string login, string password)
        {
            var result = _warehouseContext.Users.Any(x => x.Login == login && x.Password == password);
            return result;
        }
    }
}
