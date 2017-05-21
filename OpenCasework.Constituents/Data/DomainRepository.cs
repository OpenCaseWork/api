using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Constituents.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{
    public interface IDomainRepository
    {
        Task<List<Title>> Titles();
        Task<List<Suffix>> Suffixes();
        Task<List<City>> Cities();
    }


    public class DomainRepository: IDomainRepository
    {
        private ConstituentContext _context;

        public DomainRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Title>> Titles()
        {
            var query = from u in _context.Titles
                        select u;
           
            return await query.ToListAsync();
        }

        public async Task<List<Suffix>> Suffixes()
        {
            var query = from u in _context.Suffixes
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<City>> Cities()
        {
            var query = from u in _context.Cities
                        select u;

            return await query.ToListAsync();
        }

    }
}
