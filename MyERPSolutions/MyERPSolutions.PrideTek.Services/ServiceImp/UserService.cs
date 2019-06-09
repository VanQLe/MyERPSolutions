using MyERPSolutions.PrideTek.Dao.Dao;
using MyERPSolutions.PrideTek.Models;
using MyERPSolutions.PrideTek.Services.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyERPSolutions.PrideTek.Services.ServiceImp
{
    public class UserService : IUserService
    {
        private IGenericRepository _repository;
        public UserService(IGenericRepository repository)
        {
            this._repository = repository;
        }

        public async Task<User> GetUserById(long id)
        {
            var user = await this._repository.GetByIdAsync<User>(id);
            return user;
        }
    }
}
