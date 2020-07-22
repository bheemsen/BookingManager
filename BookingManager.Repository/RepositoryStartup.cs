using BookingManager.Models;
using BookingManager.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingManager.Repository
{
    public class RepositoryStartup
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IRepository<Employee>, EmployeeRepository>();            
        }
    }
}
