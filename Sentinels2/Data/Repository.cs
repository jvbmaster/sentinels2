using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Sentinels2.Data
{
    internal class Repository<T, S> where T : class, new()
                                   where S : DbContext, IDisposable, new()
    {
        private static S _context;

        public static T ObjectInstanceate = new T();
        public static T Loaded { get; set; }

        private static void Instanceate() => _context = new S(); 
  
        private static void Commit() => _context.SaveChanges();
       
        public static IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            Instanceate();
            return _context.Set<T>().Where(predicate);
        }

        public static IQueryable<T> GetAll()
        {
            Instanceate();
            return _context.Set<T>();
        }

        public static T Find(params object[] key)
        {
            Instanceate();
            return _context.Set<T>().Find(key);
        }

        public static T Find(Expression<Func<T, bool>> predicate)
        {
            Instanceate();
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public static void Load(int key)
        {
            Loaded = Find(key);
        }

        public static void Load(string key)
        {
            Loaded = Find(key);
        }

        public static void Unload()
        {
            Loaded = null;
        }

        public static void Insert(T entity)
        {
            Instanceate();
            _context.Set<T>().Add(entity);
            Commit();
        }
        
        public static void Update(T entity)
        {
            Instanceate();
            _context.Entry(entity).State = EntityState.Modified;
            Commit();
        }

        public static void Delete(Expression<Func<T, bool>> predicate)
        {
            Instanceate();
            _context.Set<T>().Where(predicate).ToList()
                .ForEach(del => _context.Set<T>().Remove(del));
            Commit();
        }

        public static void Delete(T entity)
        {
            Instanceate();
            _context.Set<T>().Remove(entity);
            Commit();
        }

        public static void Delete(int entityID)
        {
            Instanceate();
            var id = Find(entityID);
            _context.Set<T>().Remove(id);
            Commit();
        }

    }
}
