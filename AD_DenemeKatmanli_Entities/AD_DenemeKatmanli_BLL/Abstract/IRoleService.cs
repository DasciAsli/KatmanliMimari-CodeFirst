using AD_DenemeKatmanli_Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_BLL.Abstract
{
    public interface IRoleService
    {
        void Add(Roles roles);
        List<Roles> GetAll(Expression<Func<Roles, bool>> filter = null);
        Roles Get(int id);
        Roles GetDetails(int id);
        void Update(Roles roles);
        void Delete(Roles roles);
    }
}
