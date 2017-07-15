using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{

        public interface IEntityRepository
        {
            Task<List<Entity>> GetEntity(int sourceId, int entityTypeId);

        }

    public class EntityRepository : IEntityRepository
    {
        private ConstituentContext _context;

        public EntityRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Entity>> GetEntity(int sourceId, int entityTypeId)
        {
            var query = from u in _context.Entities
                        select u;
            query = query.Where(u => u.EntityTypeId == entityTypeId);
            query = query.Where(u => u.SourceEntityId == sourceId);

            return await query.ToListAsync();
        }



    }
}
