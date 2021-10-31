using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoFINAL.Entities
{
    public class User
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public User()
        {

        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }
    }
}
