using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic.Interface
{
    public interface IUserService
    {
        User GetUser(Int32 idUsr);

        IList<User> GetUsers();     
    }
}
