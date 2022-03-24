using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestApiTask.Models.User
{
    public class UserRole
    {
      public int UserId { get; set; }
        [ForeignKey("UserId")]
      
        public virtual Users Users { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("UserId")]
      
        public virtual ManageRoles ManageRoles { get; set; }
    }
}
