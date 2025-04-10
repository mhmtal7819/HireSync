using Entity;
using Repositories.EFCore;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concretes
{
    public class UserRepository : RepositoryBase<User> , IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateUser(User user) //IUserRepository
        {
            Create(user); //RepositoryBase
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public IQueryable<User> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public IQueryable<User> GetById(int id,bool trackChanges)
        {
            return FindByCondition(u => u.UserId == id, trackChanges);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }
    }
}
