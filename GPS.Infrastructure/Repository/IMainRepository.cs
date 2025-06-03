using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjecrStore.Infrastructure.Repository
{
    public interface IMainRepository<TEntity> where TEntity :class
    {
        ValueTask<string> CreateAsync(TEntity entity);
        ValueTask<string> DeleteAsync(int id);
        ValueTask<string> UpdateAsync(TEntity entity,int id);
        ValueTask<ICollection<TEntity>> GetAll();
        ValueTask<TEntity> GetOne(int id);
    }
}
