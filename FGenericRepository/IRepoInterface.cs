using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGenericRepository
{
   public interface IRepoInterface
   {
       void insert<T>(T entity) where T : BaseClass;
       void delete<T>(int id) where T : BaseClass;
       void update<T>(T x, T y) where T : BaseClass;
       IList GetAll<T>() where T : BaseClass;
       object GetById<T>(int ind) where T : BaseClass;
   }
}
