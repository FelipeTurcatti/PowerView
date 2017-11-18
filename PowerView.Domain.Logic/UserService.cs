using PowerView.DataAccess;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        #region Constructor
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        #endregion

        #region Method        
        public User GetUser(Int32 usr)
        {
            return this._userRepository.Get(usr);
        }
        public IList<User> GetUsers()
        {
            return this._userRepository.Get();
        }        
        #endregion
    }
}
