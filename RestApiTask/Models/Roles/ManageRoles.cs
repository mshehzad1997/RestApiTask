﻿using System;
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
        
        [UniqueRoleName]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<Payments> Payments { get; set; }
        public List<ManageTenant> ManageTenants { get; set; }
        public List<DemoRequest> DemoRequests { get; set; }
        public List<UserManagements> UserManagements { get; set; }
        
       
      
    }
}