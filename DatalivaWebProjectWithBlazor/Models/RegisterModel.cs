using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DatalivaWebProjectWithBlazor.Models;
using DatalivaWebProjectWithBlazor.Shared.Models;

namespace DatalivaWebProjectWithBlazor.Models
{
    public class RegisterModel : InterfaceRegisterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string EmailAdress { get; set; }
        public string Message { get; set; }
        private HttpClient _httpClient;

        public RegisterModel()
        {

        }
        public RegisterModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private void LoadObject(RegisterModel registerModel)
        {
            this.Username = registerModel.Username;
            this.Password = registerModel.Password;
            this.RePassword = registerModel.RePassword;
            this.EmailAdress = registerModel.EmailAdress;
        }
        public async Task NewUser()

        { 
            User user = this;
            await _httpClient.PutAsJsonAsync("user/1", user);
            this.Message = "The new user added to the system";
        }
        public async Task GetUser()
        {
            User user = await _httpClient.GetFromJsonAsync<User>("/user/1");
            LoadObject(user);
            this.Message = "Successfully registered";
        }

        public static implicit operator RegisterModel(User user)
        {
            return new RegisterModel
            {
                Username = user.Username,
                Password = user.Password,
                RePassword = user.Repassword,
                EmailAdress = user.EmailAdress 
            };
        }

        public static implicit operator User(RegisterModel registerModel)
        {
            return new User
            {
                Username = registerModel.Username,
                Password = registerModel.Password,
                Repassword = registerModel.RePassword,
                EmailAdress = registerModel.EmailAdress,
            };
        }
    }
}
