using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;

namespace DataAccess.Wrapper
{
    
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private WebShopContext _repoContext;

        private IUserRepository _user;
        public IUserRepository User
        {
            get
            {
                if(_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }

        public RepositoryWrapper(WebShopContext repositoryContext) 
        {
            _repoContext = repositoryContext;
        }

        public async void Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
