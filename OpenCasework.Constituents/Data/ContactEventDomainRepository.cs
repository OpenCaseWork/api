using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Models.ContactEvents;
using OpenCaseWork.Models.ContactEvents.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{
    public interface IContactEventDomainRepository
    {
        Task<List<Service>> Services();
        Task<List<ServiceType>> ServiceTypes();
    }

    public class ContactEventDomainRepository: IContactEventDomainRepository
    {
        private ConstituentContext _context;

        public ContactEventDomainRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Service>> Services()
        {
            var query = from u in _context.Services
                        where u.IsActive == true
                        orderby u.Code
                        select u;
 
            return await query.ToListAsync();
        }

        public async Task<List<ServiceType>> ServiceTypes()
        {
            var query = from u in _context.ServiceTypes
                        where u.IsActive == true
                        orderby u.Name
                        select u;

            return await query.ToListAsync();
        }
    }
}
