﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAPI.Domain.Interfaces.Repositories
{
    public interface IUnitofWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        void SaveChanges();
    }
}
