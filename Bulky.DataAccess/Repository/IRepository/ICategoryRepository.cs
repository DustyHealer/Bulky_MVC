using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // Since we have skipped the below methods in the generic repository, we can add these methods here
        void Update(Category obj);
        void Save();
    }
}
