using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using OpenCaseWork.Models.Base;
using OpenCaseWork.Core.Exceptions;

namespace OpenCaseWork.Core.Data
{
    public class Repository<T>: IRepository<T> where T: BaseEntity
    {
        private DbContext _dbContext;
        
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }       

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    
        public async Task<T> Add(T item, DbSet<T> set)
        {
            return await Add(item,set,true);
        }

        public async Task<List<T>> Add(List<T> items, DbSet<T> set)
        {           
            foreach (T item in items)
            {
                set.Add(item);
            }
            await _dbContext.SaveChangesAsync();
            return items;
        }

        public void AddWithoutSave(List<T> items, DbSet<T> set)
        {
            foreach (T item in items)
            {
                set.Add(item);
            }
        }

        public async Task<List<T>> Update(List<T> items, DbSet<T> set)
        {
            foreach (T item in items)
            {
                _dbContext.Entry(item).State = EntityState.Modified;
            }
            await _dbContext.SaveChangesAsync();
            return items;
        }

        public void UpdateWithoutSave(List<T> items, DbSet<T> set)
        {
            foreach (T item in items)
            {
                set.Add(item);
                _dbContext.Entry(item).State = EntityState.Modified;
            }
        }

        public async Task<T> Add(T item, DbSet<T> set, bool saveChanges)
        {
            set.Add(item);
            if (saveChanges)
                await _dbContext.SaveChangesAsync();   
            return item;        
        }        
    
        public async Task<T> FindByID(int id, DbSet<T> set)
        {
             T result = await set.FindAsync(id);
             if (result == null)
                throw new ObjectNotFoundException();
             return result;
        }
    
        public async Task Remove(int id, DbSet<T> set)
        {
            await Remove(id,set,true);
        }

        public async Task Remove(int id, DbSet<T> set, bool saveChanges)
        {
            var item = await FindByID(id, set);
            set.Remove(item);
            if (saveChanges)
                await _dbContext.SaveChangesAsync();
        }
    
        public async Task<T> Update(T item)
        {
            return await Update(item, true);
        }

        public async Task<T> Update(T item, bool saveChanges)
        {

            _dbContext.Entry(item).State = EntityState.Modified;
            if (saveChanges)
                await _dbContext.SaveChangesAsync();
            return item;
        }
   
    }
}