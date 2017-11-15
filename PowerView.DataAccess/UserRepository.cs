using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{
    public class UserRepository : GenericEntityFrameworkRepository<User>, IUserRepository
    {
        #region Constructor
        public UserRepository(PowerViewDbContext context) : base(context)
        {
        }
        #endregion

        #region Methods
        public IList<User> Get()
        {
            return this.Get().ToList();
        }

        public User Get(int idUsr)
        {
            return this.Get(x => x.UserId == idUsr).FirstOrDefault();
        }
        #endregion
    }
}
