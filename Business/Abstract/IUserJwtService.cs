using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserJwtService
    {
        List<OperationClaim> GetClaims(UserJwt user);
        void Add(UserJwt user);
        UserJwt GetByMail(string email);
    }
}
