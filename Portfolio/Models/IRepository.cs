using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public interface IRepository
    {
        FakeDbModel list { get; }
        void Add(Contact contact);
        void Remove(Guid id);
    }
}
