﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestApiTask.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [UniqueUserName]
        public string UserName { get; set; }
       [UniqueEmail]
        public string Email { get; set; }
        [Display(Name = "ManageRoleId")]
        public int ManageRoleId { get; set; }

        [ForeignKey("ManageRoleId")]
        [JsonIgnore]
        public virtual ManageRoles ManageRoles { get; set; }
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