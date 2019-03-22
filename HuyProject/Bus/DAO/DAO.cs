using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.DAO
{
    public interface IDAO<T>
    {
        List<T> GetAll();
        T SearchById(object id);
        bool Add(T dto);
        bool Update(T dto);
        bool DeleteById(object id);
    }
}
