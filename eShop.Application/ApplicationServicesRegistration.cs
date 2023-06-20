﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eShop.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddMediatR(conf => conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
