using System.Threading.Tasks;
using DatalivaWebProjectWithBlazor.Models;

namespace DatalivaWebProjectWithBlazor.Models
{
    public interface InterfaceRegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string EmailAdress { get; set; }
        public string Message { get; set; }

        public Task NewUser();
        public Task GetUser();
    }
}