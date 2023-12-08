using System;
using Application.Services.Repositories;
using Domain.Entities;
using Persistence.Context;
using Tobeto.Core.Persistence.Repositories;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {

        }
    }
}

