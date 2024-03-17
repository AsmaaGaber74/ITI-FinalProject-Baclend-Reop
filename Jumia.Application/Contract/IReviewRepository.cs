﻿using Jumia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumia.Application.Contract
{
    public interface IReviewRepository : IRepository<Review, int>
    {
        Task<IEnumerable<Review>> GetByUserIdAsync(string userId);
        // Additional signatures as needed...
    }
}
