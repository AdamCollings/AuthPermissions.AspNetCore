﻿// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using AuthPermissions.AdminCode;
using AuthPermissions.SetupCode;

namespace AuthPermissions
{
    /// <summary>
    /// This contains the options set by the developer and data that is passed between setup extension methods
    /// </summary>
    public class AuthPermissionsOptions
    {

        /// <summary>
        /// This defines whether tenant code is activated, and whether the
        /// multi-tenant is is a single layer, or many layers (hierarchical)
        /// Defaults no using tenants
        /// </summary>
        public TenantTypes TenantType { get; set; }

        /// <summary>
        /// You should set this property to your application's ConnectionString if you are using Tenants
        /// It's used with the <see cref="ITenantChangeService"/> to update, move, or delete the tenant data in your application
        /// </summary>
        public string AppConnectionString { get; set; }

        /// <summary>
        /// This is where you configure the JwtToken
        /// </summary>
        public AuthPJwtConfiguration ConfigureAuthPJwtToken { get; set; }

        //-------------------------------------------------
        //internal set properties/handles

        /// <summary>
        /// This holds data that is set up during the 
        /// </summary>
        public SetupInternalData InternalData { get; } = new SetupInternalData();

    }
}