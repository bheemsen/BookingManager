using System;
using System.Collections.Generic;
using System.Text;
using BookingManager.Models;
using BookingManager.Repository.Interface;
using BookingManager.Services.Interface;
namespace BookingManager.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly IRepository<Employee> employee;
        public EmployeeService(IRepository<Employee> _employee)
        {
            this.employee = _employee;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            var emp = employee.FindById(id);
            return emp != null ? emp : null;
        }
    }
}
