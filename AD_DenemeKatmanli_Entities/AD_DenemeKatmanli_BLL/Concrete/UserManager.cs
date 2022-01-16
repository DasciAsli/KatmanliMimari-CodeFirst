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
    public class UserManager : IUserService
    {
        IUsersDAL _ıuserdal;

        public UserManager(IUsersDAL ıuserdal)
        {
            _ıuserdal = ıuserdal;
        }

        public void Add(Users user)
        {

            _ıuserdal.Add(user);

        }

        public void Delete(Users user)
        {

            _ıuserdal.Delete(user);

        }

        public Users Get(int id)
        {
            return _ıuserdal.Get(x => x.UserId == id);
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> filter = null)
        {
            return _ıuserdal.GetAll();
        }

        public Users GetDetails(int id)
        {
            return _ıuserdal.GetDetails(x => x.UserId == id);
        }

        public void Update(Users user)
        {
            _ıuserdal.Update(user);
        }
    }
}
