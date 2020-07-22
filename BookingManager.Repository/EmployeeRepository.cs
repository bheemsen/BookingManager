using System;
using System.Collections.Generic;
using System.Text;
using BookingManager.Models;
using BookingManager.Repository.Interface;

namespace BookingManager.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public bool AddOrUpdate(Employee record)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee FindById(int id)
        {
            var emp = new Employee()
            {
                EmployeeId = id,
                EmployeeName = "Bheem"
            };
            return emp;
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
