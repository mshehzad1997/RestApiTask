using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class Payments
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "View Payment")]
        public bool ViewPayment { get; set; }
        [Display(Name = "Change Status")]
        public bool ChangeStatus { get; set; }

        public ManageRoles ManageRoles { get; set; }
    }
}
