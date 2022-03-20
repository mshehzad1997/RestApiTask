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
        public ManageTenant ManageTenants { get; set; }
        public DemoRequest DemoRequests { get; set; }
        
        public enum ManageTenant
        {
            RegisterTenant,
            ViewTenant,
            UpdateTenant,
            UpgradePlan,
            RessetPassword
        }
        public enum DemoRequest
        {
            ViewRequest,
            ApproveRequest
        }
    }
    public class Payments
    {
        public bool ViewPayment { get; set; }
        public bool ChangeStatus { get; set; }
    }
}
