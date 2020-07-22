using BookingManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookingManager.Services.Interface
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
