namespace WarehouseSystem.Application.Interfaces
{
    public interface IUserService
    {
        bool Registrate(string login, string password);

        bool Authorize(string login, string password);
    }
}
