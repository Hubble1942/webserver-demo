// -----------------------------------------------------------------------
// <copyright file="EndpointRouteBuilderExtensions.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using WebServerDemo.Domain.Beers;

namespace WebServerDemo.Domain;

public static class EndpointRouteBuilderExtensions
{
    public static void MapDomain(this IEndpointRouteBuilder app)
    {
        app.MapBeers();
    }

    private static void MapBeers(this IEndpointRouteBuilder app)
    {
        var beerApi = app.MapGroup("/beer");

        beerApi.MapGet("/", (BeerRepository repository) => repository.All);
        beerApi.MapPost("/", (Beer beer, BeerRepository repository) => repository.Add(beer));
        beerApi.MapDelete(
            "/{name}",
            (string name, BeerRepository repository) => repository.DeleteByName(name)
        );
    }
}
