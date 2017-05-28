﻿using Microsoft.EntityFrameworkCore;
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
        Task<List<Constituent>> Search(ConstituentSearchRequest constituent);
    }

    public class ConstituentRepository : IConstituentRepository
    {
        private ConstituentContext _context;

        public ConstituentRepository(ConstituentContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Constituent>> Search(ConstituentSearchRequest request)
        {
            var query = from u in _context.Constituents
                        select u;

            if (!String.IsNullOrEmpty(request.Address))
                query = query.Where(u => u.Address1.StartsWith(request.Address));

            if (!String.IsNullOrEmpty(request.LastName))
                query = query.Where(u => u.LastName.StartsWith(request.LastName));

            if (!String.IsNullOrEmpty(request.FirstName))
                query = query.Where(u => u.FirstName.StartsWith(request.FirstName));

            return await query.ToListAsync();
        }

    }
}
