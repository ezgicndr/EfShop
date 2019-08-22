using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseRepository<T> where T:class, IEntity
    {
        protected BaseRepository<T> rep;
        protected myShopEntities db;
        public BaseRepository()
        {
            
        }
        public virtual List<T> List()
        {
            db = new myShopEntities();
            List<T> result = new List<T>();
            try
            {
                result = db.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public virtual void Insert(T entity)
        {

            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            myShopEntities db = new myShopEntities();

            T p = db.Set<T>().Where(c => c.Id == id).FirstOrDefault();
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

    }
}
