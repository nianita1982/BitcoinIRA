using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin.Data.Repository.IRepository
{
    public interface IBasicTransactions<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
    }
}
