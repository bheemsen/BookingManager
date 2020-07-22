using System;
using System.Collections.Generic;
using System.Text;
using BookingManager.Repository;
using BookingManager.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace BookingManager.Services
{
    public class ServiceStartup
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IEmployee, EmployeeService>();
            
            RepositoryStartup.Register(services);
        }
    }
}
