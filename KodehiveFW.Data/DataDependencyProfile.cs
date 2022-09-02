using KodehiveFW.Data.Interface.Repositories;
using KodehiveFW.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodehiveFW.Data
{
    public class DataDependencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaRepository, MahasiswaRepository>();
        }
    }
}
