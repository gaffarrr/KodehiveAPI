using KodehiveFW.Service.Interface.Services;
using KodehiveFW.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Service
{
    public class ServiceDependencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection service)
        {
            service.AddScoped<IMahasiswaService, MahasiswaService>();
            service.AddScoped<IDBService, DBService>();
        }
    }
}
