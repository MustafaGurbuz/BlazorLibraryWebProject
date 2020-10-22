
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatalivaWebProjectWithBlazor.Shared.Models
{
    public partial class User
    {
        public User()
    {

    }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }
        public string Username { get; set; }
        public string LoginPassword { get; set; }
    }
}