using System;
using System.Collections.Generic;
using System.Text;

namespace BookingManager.Repository.Interface
{

    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T FindById(int id);
        bool AddOrUpdate(T record);
        bool Delete(int id);
    }
}
