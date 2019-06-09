using MyERPSolutions.PrideTek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyERPSolutions.PrideTek.Services.Service
{
    interface IUserService
    {
        Task<User> GetUserById(long id);
    }
}
