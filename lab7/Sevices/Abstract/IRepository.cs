namespace lab7.Sevices.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Create(T entity);

    }
}
