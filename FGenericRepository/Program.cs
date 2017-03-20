using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGenericRepository
{
    class Program
    {
       static Repository obj = new Repository();
        static void Main(string[] args)
        {

            Book b1 = new Book {id = 1, author = "kanon", price = 500};
            Book b2 = new Book {id = 2, author = "nahid", price = 200};
            TransactionModel t1 = new TransactionModel {id = 1, author = "hime", amount = 700};

            obj.insert(b1);
            obj.insert(b2);

            obj.delete<Book>(b1.id);
           // obj.update(b1,new Book {id=1,author = "rasel",price = 300});
          //  var ans = obj.GetById<TransactionModel>(1);

            var result = obj.GetAll<Book>();

        }
    }
}
