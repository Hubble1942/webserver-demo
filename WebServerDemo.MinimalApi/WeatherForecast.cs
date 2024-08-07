// -----------------------------------------------------------------------
// <copyright file="WeatherForecast.cs" company="Christian Ewald">
// Copyright (c) Christian Ewald. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace WebServerDemo.MinimalApi;

internal sealed record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);
}
