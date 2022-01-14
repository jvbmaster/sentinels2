using System.Linq.Expressions;

namespace Sentinels2.Data
{
    internal interface IRepository<T> where T : class 
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> Select();
        T Find(params object[] key);
        T Find(Expression<Func<T, bool>> predicate);
        void Load(int key);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Expression<Func<T, bool>> predicate);
        void Delete(T entity);
        void Delete(int entityID);
        void Commit();
        void Dispose();
    }
}
