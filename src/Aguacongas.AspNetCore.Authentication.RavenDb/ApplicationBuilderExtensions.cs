﻿// Project: aguacongas/DymamicAuthProviders
// Copyright (c) 2021 @Olivier Lefebvre
using Aguacongas.AspNetCore.Authentication.RavenDb;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// IApplicationBuilder extensions
    /// </summary>
    public static  class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Loads the dynamic authentication configuration.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static IApplicationBuilder LoadDynamicAuthenticationConfiguration(this IApplicationBuilder builder)
        {
            builder.ApplicationServices.LoadDynamicAuthenticationConfiguration<SchemeDefinition>();
            return builder;
        }
    }
}
