// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using WebServerDemo.Domain.Beers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBeers();

var app = builder.Build();

app.MapBeers();

app.Run();
