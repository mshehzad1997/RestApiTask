using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class RolesManage
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Create User")]
        public bool CreateUser { get; set; }
        [Display(Name = "View Role")]
        public bool ViewRole { get; set; }
        [Display(Name = "Update Role")]
        public bool UpdateRole { get; set; }
        public UserManagements UserManagements { get; set; }
    }
}
