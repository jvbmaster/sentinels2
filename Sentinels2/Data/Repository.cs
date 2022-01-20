using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Sentinels2.Data
{
    internal class Repository<T, S> where T : class, new()
                                   where S : DbContext, IDisposable, new()
    {
        private static S? _context;

        public static T? ObjectInstanceate = new T();
        public static T? Loaded { get; set; }

        public static IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            _context = new S();
           return _context.Set<T>().Where(predicate);
        }

        public static IQueryable<T> GetAll()
        {
            _context = new S();
            return _context.Set<T>();

        }

        public static T ?Find(params object[] key)
        {
            _context = new S();
            return _context.Set<T>().Find(key);
        }

        public static T ?Find(Expression<Func<T, bool>> predicate)
        {
            _context = new S();
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
            _context = new S();
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        
        public static void Update(T entity)
        {
            _context = new S();
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public static void Delete(Expression<Func<T, bool>> predicate)
        {
            _context = new S();
            _context.Set<T>().Where(predicate).ToList().ForEach(del => _context.Set<T>().Remove(del));
            _context.SaveChanges();
        }

        public static void Delete(T entity)
        {
            _context = new S();
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public static void Delete(int entityID)
        {
            _context = new S();
            var id = Find(entityID);
            _context.Set<T>().Remove(id);
            _context.SaveChanges();
        }

    }
}
