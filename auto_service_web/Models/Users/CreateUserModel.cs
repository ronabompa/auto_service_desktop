using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Models.Users
{
    public class CreateUserModel
    {
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string username { get; set; }

        [StringLength(60, MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string name { get; set; }
    }
}
