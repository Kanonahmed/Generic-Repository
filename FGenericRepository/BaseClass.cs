using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGenericRepository
{
   public abstract class BaseClass
   {
       public int id;
       public string author; 
   }

    public class Book: BaseClass
    {
        public int price;
    }

    public class TransactionModel:BaseClass
    {
        public int amount;
    }

    public class Employee:BaseClass
    {
        public int salary;
    }
}
