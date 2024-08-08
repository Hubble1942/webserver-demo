// -----------------------------------------------------------------------
// <copyright file="BeerRepository.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace WebServerDemo.Domain.Beers;

public sealed class BeerRepository
{
    private readonly List<Beer> store =
    [
        new("Heineken", 0.05),
        new("Feldschlösschen", 0.048),
        new("Calanda", 0.048),
    ];

    public IEnumerable<Beer> All => this.store;

    public void Add(Beer beer) => this.store.Add(beer);

    public void DeleteByName(string name) => this.store.RemoveAll(b => b.Name == name);
}
