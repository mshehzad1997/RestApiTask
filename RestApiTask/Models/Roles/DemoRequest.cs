using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class DemoRequest
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "View Request")]
        public bool ViewRequest { get; set; }
        [Display(Name = "Approve Request")]
        public bool ApproveRequest { get; set; }
        [Display(Name = "Manage Role")]
        public int ManageRoleId { get; set; }
        [ForeignKey("ManageRoleId")]
        public ManageRoles ManageRoles { get; set; }
    }
}
