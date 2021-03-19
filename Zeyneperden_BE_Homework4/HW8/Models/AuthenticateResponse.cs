using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HW8.Entities;

namespace HW8.Models
{
    public class AuthenticateResponse
    {
        public string LoginUser { get; set; }
        public string LoginPassword { get; set; }

        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(UserEntity user, string jwtToken, string refreshToken)
        {
            LoginUser = user.LoginName;
            LoginPassword = user.Password;
        }
    }
}
