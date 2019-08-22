using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository:BaseRepository<Users>
    {

        public Users Update ( Users entity)
        {
            db = new myShopEntities();
            Users defaultUser = db.Users.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaultUser.FullName = entity.FullName;
            defaultUser.UserName = entity.UserName;
            defaultUser.Password = entity.Password;
            defaultUser.Credit = entity.Credit;
            db.SaveChanges();
            
            return defaultUser;
        }

    }
}
