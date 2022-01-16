using AD_DenemeKatmanli_Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_BLL.Abstract
{
    public interface IUserService
    {
        void Add(Users user);
        List<Users> GetAll(Expression<Func<Users, bool>> filter = null);
        Users Get(int id);
        Users GetDetails(int id);
        void Update(Users user);
        void Delete(Users user);
    }
}
