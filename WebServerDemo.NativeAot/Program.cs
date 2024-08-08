// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using WebServerDemo.Domain;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDomainForAot();

var app = builder.Build();

app.MapDomain();

app.Run();
