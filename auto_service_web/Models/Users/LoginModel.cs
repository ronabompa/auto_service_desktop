using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Models.Users
{
    public class LoginModel
    {
        [Required]
        public string username { get; set; }
        
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }
}
