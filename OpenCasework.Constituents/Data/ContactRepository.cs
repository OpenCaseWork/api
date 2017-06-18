using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Models.Constituents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{
    public interface IContactRepository
    {
        Task<List<ConstituentContact>> GetContactsForConstituentId(int constituentId);
    }

    public class ContactRepository: IContactRepository
    {
        private ConstituentContext _context;

        public ContactRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<ConstituentContact>> GetContactsForConstituentId(int constituentId)
        {
            var query = from u in _context.Contacts                       
                        select u;
            query = query.Where(u => u.ConstituentId.Equals(constituentId));

            return await query.ToListAsync();
        }
    }
}
