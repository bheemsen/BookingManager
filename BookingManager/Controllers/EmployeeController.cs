using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using BookingManager.Models;
using BookingManager.Services.Interface;
using BookingManager.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace BookingManager.Controllers
{
    [Produces("application/json")]
    
    public class EmployeeController : BaseController
    {
        private readonly IRepository<Employee> employee;
        private readonly IConfiguration configuration;
        public EmployeeController(IRepository<Employee> _employee, IConfiguration _configuration)
        {
            this.employee = _employee;
            this.configuration = _configuration;
        }

        
        public Employee GetEmployee(int id)
        {
            var appName = configuration.GetSection("Logging:LogLevel:Default");
            return employee.FindById(id);
        }

        
        public string Index()
        {
            return "OK";
        }
    }
}
