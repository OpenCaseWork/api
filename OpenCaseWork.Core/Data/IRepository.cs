using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using OpenCaseWork.Models.Base;

namespace OpenCaseWork.Core.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Add(T item, DbSet<T> set);
        Task<List<T>> Add(List<T> items, DbSet<T> set);
        void AddWithoutSave(List<T> items, DbSet<T> set);
        Task<List<T>> Update(List<T> items, DbSet<T> set);
        Task Remove(int id, DbSet<T> set);
        Task Save();
        Task<T> Update(T item);
        void UpdateWithoutSave(List<T> items, DbSet<T> set);
        Task<T> FindByID(int id, DbSet<T> set);        
    }
}    