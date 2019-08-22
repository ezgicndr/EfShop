using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository:BaseRepository<Products>
    {
        public Products Update (Products entity)
        {
            db = new myShopEntities();
            Products p = db.Products.Where(c => c.Id == entity.Id).FirstOrDefault();
            p.Name = entity.Name;
            p.Price = entity.Price;
            p.stocks = entity.stocks;
            p.productCode = entity.productCode;
            db.SaveChanges();
            return p;
        }

        public List<Products> GetProductInStock(int catId)
        {
            List<Products> result = new List<Products>();
            if(catId==0)
            {
                result = db.Products.Where(c => c.stocks > 0).ToList();
            }
            else
            {
                result = db.Products.Where(c => c.stocks > 0 && c.categoryId == catId).ToList();
            }
            return result;
        }
      
    }

}
