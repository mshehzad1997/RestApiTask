using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class ManageRoles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [UniqueRoleName]
        public string RoleName { get; set; }
        [Required]
        public string Description { get; set; }
        public List<Payments> Payments { get; set; }
        public List<ManageTenant> ManageTenants { get; set; }
        public List<DemoRequest> DemoRequests { get; set; }
        
       
      
    }
    public class Payments
    {
        [Key]
        public int Id { get; set; }
        public bool ViewPayment { get; set; }
        public bool ChangeStatus { get; set; }
        public ManageRoles ManageRoles { get; set; }
    }
    public class ManageTenant
    {
        [Key]
        public int Id { get; set; }
        public bool RegisterTenant { get; set; }
        public bool ViewTenant { get; set; }
        public bool UpdateTenant { get; set; }
        public bool UpgradePlan { get; set; }
        public bool RessetPassword { get; set; }
        public ManageRoles ManageRoles { get; set; }
    }
    public class DemoRequest
    {
        [Key]
        public int Id { get; set; }
        public bool ViewRequest { get; set; }
        public bool ApproveRequest { get; set; }
        public ManageRoles ManageRoles { get; set; }


    }
}
