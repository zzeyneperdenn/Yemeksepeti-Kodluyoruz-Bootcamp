using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Entities;
using HW8.Models;

namespace HW8.Services
{
    public interface IUserService
    {
        Task<UserInfo> Authenticate(TokenRequest req);


        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<UserEntity> GetAll();
        UserEntity GetById(int id);
    }
}
