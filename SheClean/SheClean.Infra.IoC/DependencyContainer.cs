﻿using Microsoft.Extensions.DependencyInjection;
using SheClean.Application.Interfaces;
using SheClean.Application.Services;
using SheClean.Domain.Interfaces;
using SheClean.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SheClean.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IPatientService, PatientService>();

            //Infra.Data Layer
            services.AddScoped<IPatientRepository, PatientRepository>();
        }
    }
}
