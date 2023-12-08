using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Category:Entity<Guid> //<Guid>
    {
        public string Name { get; set; }
        public Category()
        {
            
        }
        public Category(Guid id, string name):this()
        {
            Id = id;
            Name = name;
        }

    }
}
