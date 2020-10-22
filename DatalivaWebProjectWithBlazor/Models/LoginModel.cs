using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DatalivaWebProjectWithBlazor.Shared.Models;

namespace DatalivaWebProjectWithBlazor.Models
{
    public class LoginModel : InterfaceLoginModel
    {
        public string Username { get; set; }
        public string LoginPassword { get; set; }
        private HttpClient _httpClient;
        public LoginModel()
        {

        }
        public LoginModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public static implicit operator LoginModel(User user)
        {
            return new LoginModel
            {
                Username = user.Username,
                LoginPassword = user.LoginPassword
            };
        }

        public static implicit operator User(LoginModel loginModel)
        {
            return new User
            {
                Username = loginModel.Username,
                LoginPassword = loginModel.LoginPassword
            };
        }

        public async Task LoginUser()
        {
            await _httpClient.PostAsJsonAsync<User>("/", this);
        }
    }
}