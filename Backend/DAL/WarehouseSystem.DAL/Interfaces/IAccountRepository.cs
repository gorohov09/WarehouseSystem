namespace WarehouseSystem.DAL.Interfaces
{
    public interface IAccountRepository
    {
        bool Registrate(string login, string password);

        bool Authorize(string login, string password);

        bool UserExists(string login, string password);
    }
}
