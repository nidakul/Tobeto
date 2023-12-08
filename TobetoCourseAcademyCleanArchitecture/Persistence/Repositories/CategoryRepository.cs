﻿using System;
using Application.Services.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using Tobeto.Core.Persistence.Repositories;

namespace Persistence.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category, Guid, BaseDbContext>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {

        }
    }
}


