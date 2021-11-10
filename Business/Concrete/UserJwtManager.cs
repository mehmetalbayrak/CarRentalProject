using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserJwtManager : IUserJwtService
    {
        IUserJwtDal _userDal;

        public UserJwtManager(IUserJwtDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(UserJwt user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(UserJwt user)
        {
            _userDal.Add(user);
        }

        public UserJwt GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
