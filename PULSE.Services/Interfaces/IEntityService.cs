using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IEntityService<T, TSearch> where T : class where TSearch : class
    {
        T GetById(int id, TSearch? search = null);
    }
}
