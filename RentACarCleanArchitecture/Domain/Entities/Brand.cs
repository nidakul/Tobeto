using System;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Brand : Entity<Guid>  //id'im Guid veri türündedir demek
	{
		public string Name { get; set; }
		
	}
}


