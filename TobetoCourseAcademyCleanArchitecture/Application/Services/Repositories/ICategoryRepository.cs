using System;
using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services.Repositories
{
	public interface ICategoryRepository : IRepository<Category, Guid> , IAsyncRepository<Category, Guid>
	{
	}
}

