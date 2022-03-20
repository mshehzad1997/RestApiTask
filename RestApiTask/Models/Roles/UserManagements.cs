using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class UserManagements
    {
        [Key]
        public int Id { get; set; }
        public List<ManageUsers> manageUsers { get; set; }
        public List<RolesManage> rolesManages { get; set; }
        public ManageRoles ManageRoles { get; set; }
    }
}
