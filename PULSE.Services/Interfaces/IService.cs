using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IService<T, TSearch> where T: class where TSearch : class
    {
        IEnumerable<T> Get(TSearch search = null);
        T GetById(int id);
    }
}
