using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class UserRoles
    {
        public int UserId { get; set; }
        public Users Users { get; set; }
        public int RoleId { get; set; }
        public ManageRoles ManageRoles { get; set; }
    }
}
