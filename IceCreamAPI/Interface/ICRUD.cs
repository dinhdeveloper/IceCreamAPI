using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamAPI.Interface
{
   public interface ICRUD<T>
    {
        List<T> GetAll();
        T GetId(int Id);
        T Delete(int id);

        T Insert(T t);

        T Update(T t);
    }
}
