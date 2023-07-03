using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAPI.Domain.Interfaces.Repositories;
using UsersAPI.Infra.Data.Contexts;

namespace UsersAPI.Infra.Data.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private readonly DataContext? _dataContext;

        public UnitofWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IUserRepository UserRepository => new UserRepository(_dataContext);

        public void Dispose()
        {
            _dataContext?.Dispose();
        }

        public void SaveChanges()
        {
            _dataContext?.SaveChanges();
        }
    }
}
