using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository:BaseRepository<Categories>
    {
        public Categories Update(Categories entity)
        {
            db = new myShopEntities();
            Categories cat = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            cat.Name = entity.Name;
            cat.Description = entity.Description;
            cat.CatOrder = entity.CatOrder;
            db.SaveChanges();
            return cat;
        }
    }
}
