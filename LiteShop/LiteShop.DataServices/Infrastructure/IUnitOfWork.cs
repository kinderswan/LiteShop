namespace LiteShop.DataServices.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}