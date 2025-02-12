﻿// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;
using AuthPermissions.CommonCode;
using AuthPermissions.DataLayer.Classes;
using Microsoft.EntityFrameworkCore;

namespace Example4.ShopCode.EfCoreClasses
{
    [Index(nameof(FullName), IsUnique = true)]
    public class RetailOutlet : IDataKeyFilterReadOnly
    {
        private RetailOutlet() { } //Needed by EF Core

        public RetailOutlet(int authPTenantId, string fullName, string dataKey)
        {
            if (authPTenantId == 0) throw new ArgumentNullException(nameof(authPTenantId));

            AuthPTenantId = authPTenantId;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            ShortName = Tenant.ExtractEndLeftTenantName(FullName);
            DataKey = dataKey ?? throw new ArgumentNullException(nameof(dataKey));
        }

        public int RetailOutletId { get; private set; }

        /// <summary>
        /// This contains the fullname of the AuthP Tenant
        /// </summary>
        public string FullName { get; private set; }

        public string ShortName { get; private set; }

        /// <summary>
        /// This contains the datakey from the AuthP's Tenant
        /// </summary>
        public string DataKey { get; private set; }

        /// <summary>
        /// This is here in case a hierarchical AuthP Tenant has its position in the hierarchy changes.
        /// It this happens the DataKey and the FullName will change, so you need to update the RetailOutlet
        /// </summary>
        public int AuthPTenantId { get; private set; }

        //------------------------------------------------------------------------------
        //access methods

        public void UpdateDataKey(string newDataKey)
        {
            DataKey = newDataKey;
        }

        public void UpdateNames(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                throw new ArgumentException("The FullName cannot be null or empty");

            FullName = fullName;
            ShortName = Tenant.ExtractEndLeftTenantName(FullName);
        }
    }
}