// -----------------------------------------------------------------------
// <copyright file="ServiceCollectionExtensions.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using WebServerDemo.Domain.Beers;

namespace WebServerDemo.Domain;

public static class ServiceCollectionExtensions
{
    public static void AddDomain(this IServiceCollection services)
    {
        services.AddSingleton<BeerRepository>();
    }

    public static void AddDomainForAot(this IServiceCollection services)
    {
        services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.TypeInfoResolverChain.Insert(
                0,
                DomainJsonSerializerContext.Default
            );
        });

        services.AddDomain();
    }
}
