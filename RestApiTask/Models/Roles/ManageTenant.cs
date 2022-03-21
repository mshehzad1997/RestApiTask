using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class ManageTenant
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Register Tenant")]
        public bool RegisterTenant { get; set; }
        [Display(Name = "View Tenant")]
        public bool ViewTenant { get; set; }
        [Display(Name = "Update Tenant")]
        public bool UpdateTenant { get; set; }
        [Display(Name = "Upgrade Plan ")]
        public bool UpgradePlan { get; set; }
        [Display(Name = "Resset Password")]
        public bool RessetPassword { get; set; }
        public ManageRoles ManageRoles { get; set; }
    }
}
