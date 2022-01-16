using AD_DenemeKatmanli_Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DenemeKatmanli_Entities.Model
{
    public class Users:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Roles { get; set; }

    }
}
