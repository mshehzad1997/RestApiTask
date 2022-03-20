using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class ManageUsers
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Create User")]
        public bool CreateUser { get; set; }
        [Display(Name = "Update User")]
        public bool UpdateUser { get; set; }
        [Display(Name = "Inactive")]
        public bool Inactive { get; set; }
        [Display(Name = "Reset")]
        public bool Reset { get; set; }
        public UserManagements UserManagements { get; set; }
       
    }
}
