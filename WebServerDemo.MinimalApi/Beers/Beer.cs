// -----------------------------------------------------------------------
// <copyright file="Beer.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace WebServerDemo.MinimalApi.Beers;

public sealed record Beer(string Name, double AlcoholByVolume) { }
