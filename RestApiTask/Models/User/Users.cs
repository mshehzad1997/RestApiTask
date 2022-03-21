using System;
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
         [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [UniqueUserName]
        public string UserName { get; set; }
       [UniqueEmail]
        public string Email { get; set; }
        [Display(Name = "ManageRoleId")]
        [Required]
        public int ManageRoleId { get; set; }
        
        [ForeignKey("ManageRoleId")]
        [JsonIgnore]
        public virtual ManageRoles ManageRoles { get; set; }
        [Required]
        public gender Gender { get; set; }
        public bool Status { get; set; }
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters  ")]
        [Required]
        public string Password { get; set; }
        public enum gender
        {
            Male,
            Female
        }
    }
}
