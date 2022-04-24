namespace Core.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IPersonRepository Person { get; }

        IAdressRepository Adress { get; }

        int Save();
    }
}
