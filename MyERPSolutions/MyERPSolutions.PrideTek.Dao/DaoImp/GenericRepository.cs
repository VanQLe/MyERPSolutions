using MyERPSolutions.PrideTek.Dao.Dao;
using MyERPSolutions.PrideTek.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyERPSolutions.PrideTek.Dao.DaoImp
{
    public class GenericRepository : IGenericRepository
    {
        public async Task<T> GetByIdAsync<T>(long id) where T : class, IEntity
        {
            using (var dataContext = new MyERPSolutionsDataContext())
            {
                var dataSet = dataContext.Set<T>();
                var entity = await dataSet.FindAsync(id);
                return entity;
            }
        }
    }
}
