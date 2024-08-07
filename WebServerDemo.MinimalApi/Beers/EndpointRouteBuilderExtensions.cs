// -----------------------------------------------------------------------
// <copyright file="EndpointRouteBuilderExtensions.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace WebServerDemo.MinimalApi.Beers;

public static class EndpointRouteBuilderExtensions
{
    private const string RoutePrefix = "/beer";

    public static void MapBeer(this IEndpointRouteBuilder app)
    {
        app.MapGet(RoutePrefix, (BeerRepository repository) => repository.All.OrderBy(b => b.Name));
        app.MapPost(RoutePrefix, (Beer beer, BeerRepository repository) => repository.Add(beer));
        app.MapDelete(
            RouteTemplate("{name}"),
            (string name, BeerRepository repository) => repository.DeleteByName(name)
        );
    }

    private static string RouteTemplate(string postfix) => $"{RoutePrefix}/{postfix}";
}
