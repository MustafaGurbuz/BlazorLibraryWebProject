
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatalivaWebProjectWithBlazor.Models
{
    public interface InterfaceLoginModel
    {
        public string Username { get; set; }
        public string LoginPassword { get; set; }

        public Task LoginUser();
    }
}