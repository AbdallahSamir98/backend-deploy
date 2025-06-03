using GraduationProjecrStore.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace GraduationProjecrStore.Infrastructure.Repository
{
    public class MainRepository<TEntity> : IMainRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _app;
        private readonly DbSet<TEntity> _entity;

        public MainRepository(AppDbContext app)
        {
            this._app = app;
            _entity = _app.Set<TEntity>();   
        }

        public async ValueTask<string> CreateAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            var createResult = await _app.SaveChangesAsync();

            return createResult > 0 ? "Successfully" : "Failed";

        }

        public async ValueTask<string> DeleteAsync(int id)
        {
            var entity = await _entity.FindAsync(id);
            if (entity == null)
                return "NotFound";

            _entity.Remove(entity);
            var deletingResult = await _app.SaveChangesAsync();
            return deletingResult > 0? "Successfully" : "Failed";   
        }

        public async ValueTask<ICollection<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public async ValueTask<TEntity> GetOne(int id)
        {
            return await _entity.FindAsync(id);
        }

        public async  ValueTask<string> UpdateAsync(TEntity entity, int id)
        {
            var oldEntity = await _entity.FindAsync(id);

            if (oldEntity == null)
                return "NotFound";

            _entity.Entry(oldEntity).CurrentValues.SetValues(entity);
            var updatingResult = await _app.SaveChangesAsync();

            return updatingResult > 0 ? "Successfully" : "Failed";
        }
    }
}
