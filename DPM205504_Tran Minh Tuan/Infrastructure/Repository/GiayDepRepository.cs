using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IGiayDepRepository : IRepository<GiayDep>
    {
    }

    public class GiayDepRepository : Repository<GiayDep>, IGiayDepRepository
    {
        public GiayDepRepository(EXDbContext context) : base(context)
        {
        }
    }
}
