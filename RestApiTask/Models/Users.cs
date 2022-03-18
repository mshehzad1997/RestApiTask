using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
      
        public string Email { get; set; }
        [Display(Name = "ManageRoleId")]
        public int ManageRoleId { get; set; }

        [ForeignKey("ManageRoleId")]

        public virtual ManageRoles PricingPlan { get; set; }
        public gender Gender { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }
        public enum gender
        {
            Male,
            Female
        }
    }
}
