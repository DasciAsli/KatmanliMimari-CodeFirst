using AD_DenemeKatmanli_Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_Entities.Model
{
    public class Roles:IEntity
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
