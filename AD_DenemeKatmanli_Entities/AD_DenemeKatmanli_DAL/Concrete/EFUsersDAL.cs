using AD_DenemeKatmanli_Core.DataAccessLayer;
using AD_DenemeKatmanli_Core.Entities;
using AD_DenemeKatmanli_DAL.Abstract;
using AD_DenemeKatmanli_Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_DAL.Concrete
{
    public class EFUsersDAL:GenericRepositoryBase<Context,Users>,IUsersDAL
    {
    }
}
