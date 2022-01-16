using AD_DenemeKatmanli_BLL.Abstract;
using AD_DenemeKatmanli_DAL.Abstract;
using AD_DenemeKatmanli_Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_BLL.Concrete
{
    public class RoleManager : IRoleService
    {
        IRolesDAL _ırolesdal;

        public RoleManager(IRolesDAL ırolesdal)
        {
            _ırolesdal = ırolesdal;
        }

        public void Add(Roles roles)
        {
            _ırolesdal.Add(roles);
        }

        public void Delete(Roles roles)
        {
            _ırolesdal.Delete(roles);
        }

        public Roles Get(int id)
        {
            return _ırolesdal.Get(x => x.RoleId == id);
        }

        public List<Roles> GetAll(Expression<Func<Roles, bool>> filter = null)
        {
            return _ırolesdal.GetAll();
        }

        public Roles GetDetails(int id)
        {
            return _ırolesdal.GetDetails(x => x.RoleId == id);
        }

        public void Update(Roles roles)
        {
            _ırolesdal.Update(roles);
        }
    }
}
