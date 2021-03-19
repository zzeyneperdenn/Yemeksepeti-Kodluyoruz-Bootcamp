using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.DI.Extensions
{
    public static class ServicesConfigurationExtensions
    {
        public static void AddProjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITopicRepository, TopicRepository>();
        }

        public static void AddProjectServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
