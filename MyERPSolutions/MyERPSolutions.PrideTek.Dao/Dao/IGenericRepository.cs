using MyERPSolutions.PrideTek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyERPSolutions.PrideTek.Dao.Dao
{
    public interface IGenericRepository
    {
        Task<T> GetByIdAsync<T>(long id) where T : class, IEntity;
    }
}
