using AD_DenemeKatmanli_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_Core.DataAccessLayer
{
    public interface IRepositoryBase<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        T GetDetails(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
    }
}
