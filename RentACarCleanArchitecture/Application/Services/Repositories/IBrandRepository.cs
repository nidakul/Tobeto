using System;
using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services.Repositories
{
    //IBrandDal gibi
    //IRepository<Brand, Guid> senkron olan kısım
    //Yapı hem senkronu hem asenkronu destekliyor 
    public interface IBrandRepository : IRepository<Brand, Guid>, IAsyncRepository<Brand, Guid>
	{
	}
}

