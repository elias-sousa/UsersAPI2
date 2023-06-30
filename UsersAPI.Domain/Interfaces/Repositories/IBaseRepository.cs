namespace UsersAPI.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Func<TEntity, bool> where);
        TEntity? GetById(TEntity id);
        TEntity? Get(Func<TEntity, bool> where);
    }
}
