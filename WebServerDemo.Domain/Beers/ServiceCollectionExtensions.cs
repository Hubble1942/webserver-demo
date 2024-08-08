// -----------------------------------------------------------------------
// <copyright file="ServiceCollectionExtensions.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace WebServerDemo.Domain.Beers;

public static class ServiceCollectionExtensions
{
    public static void AddBeers(this IServiceCollection services)
    {
        services.AddSingleton<BeerRepository>();
    }
}
