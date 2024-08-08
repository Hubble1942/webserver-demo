// -----------------------------------------------------------------------
// <copyright file="BeerController.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using WebServerDemo.Domain.Beers;

namespace WebServerDemo.Controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class BeerController(BeerRepository repository) : ControllerBase
{
    [HttpGet]
    public IEnumerable<Beer> Get() => repository.All;

    [HttpPost]
    public void Add(Beer beer) => repository.Add(beer);

    [HttpDelete("{name}")]
    public void DeleteByName(string name) => repository.DeleteByName(name);
}
