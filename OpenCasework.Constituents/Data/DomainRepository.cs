using Microsoft.EntityFrameworkCore;
using OpenCaseWork.Models.Constituents.Domains;
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
        Task<List<ContactType>> ContactTypes();
        Task<List<PostalCode>> PostalCodes();
        Task<List<PostalCodeCity>> PostalCodeCities();
        Task<List<State>> States();
        Task<List<Township>> Townships();
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
            var query = from u in _context.Titles orderby u.TitleText
                        select u;
           
            return await query.ToListAsync();
        }

        public async Task<List<Suffix>> Suffixes()
        {
            var query = from u in _context.Suffixes orderby u.SuffixText
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<City>> Cities()
        {
            var query = from u in _context.Cities orderby u.CityName
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<ContactType>> ContactTypes()
        {
            var query = from u in _context.ContactTypes
                        orderby u.Description
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<PostalCode>> PostalCodes()
        {
            var query = from u in _context.PostalCodes
                        orderby u.Code
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<PostalCodeCity>> PostalCodeCities()
        {
            var query = from u in _context.PostalCodeCities
                        orderby u.PostalCode
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<State>> States()
        {
            var query = from u in _context.States
                        orderby u.StateCd
                        select u;

            return await query.ToListAsync();
        }

        public async Task<List<Township>> Townships()
        {
            var query = from u in _context.Townships
                        orderby u.TownshipName
                        select u;

            return await query.ToListAsync();
        }

         
    }
}
