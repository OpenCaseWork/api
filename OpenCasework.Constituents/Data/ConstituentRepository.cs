using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Constituents.Models;
using OpenCaseWork.Constituents.Models.Search;
using OpenCaseWork.Models.Constituents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCaseWork.Constituents.Data
{

    public interface IConstituentRepository
    {
        Task<List<ConstituentSearchRecord>> Search(ConstituentSearchRequest constituent);
        Task<int> GetNextConstituentId();
        Task<List<ConstituentContact>> GetContactsForConstituentId(int constituentId);
        Task<List<ConstituentQuestionnaire>> GetQuestionnaires(int constituentId);
     }

    public class ConstituentRepository : IConstituentRepository
    {
        private ConstituentContext _context;

        public ConstituentRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<int> GetNextConstituentId()
        {
            return await Task.FromResult(2);
        }

        public async Task<List<ConstituentSearchRecord>> Search(ConstituentSearchRequest request)
        {
            var query = from u in _context.ConstituentSearchRecords
                        select u;

            if (!String.IsNullOrEmpty(request.Address))
                query = query.Where(u => u.Address.StartsWith(request.Address));

            if (!String.IsNullOrEmpty(request.LastName))
                query = query.Where(u => u.LastName.StartsWith(request.LastName));

            if (!String.IsNullOrEmpty(request.FirstName))
                query = query.Where(u => u.FirstName.StartsWith(request.FirstName));

            return await query.ToListAsync();
        }

        public async Task<List<ConstituentQuestionnaire>> GetQuestionnaires(int constituentId) {
            var query = from u in _context.Questionnaires
                        join p in _context.Providers on u.ProviderId equals p.Id
                        where u.ConstituentId == constituentId
                        select new ConstituentQuestionnaire { Id = u.Id, CreateDate = u.CreatedDate, ProviderNumber = p.ProviderNumber };

            return await query.ToListAsync();
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
