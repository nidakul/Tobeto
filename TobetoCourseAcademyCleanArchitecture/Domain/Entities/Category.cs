using System;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Category : Entity<Guid>
	{
        public string Name { get; set; }
        public string Description { get; set; } 

        public Category()
        {
        }

        
        public Category(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }
    }
}
