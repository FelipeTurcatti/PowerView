﻿using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess.Abstractions
{
    public interface IUserRepository
    {
        User Get(Int32 usrID);

        IList<User> Get();
    }
}
