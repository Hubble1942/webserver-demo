// -----------------------------------------------------------------------
// <copyright file="DomainJsonSerializerContext.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Text.Json.Serialization;
using WebServerDemo.Domain.Beers;

namespace WebServerDemo.Domain;

[JsonSerializable(typeof(IEnumerable<Beer>))]
internal partial class DomainJsonSerializerContext : JsonSerializerContext { }
