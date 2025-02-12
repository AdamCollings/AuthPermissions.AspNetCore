﻿// Copyright (c) 2021 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using AuthPermissions.SetupCode;

namespace Example2.WebApiWithToken.IndividualAccounts.PermissionsCode
{
    public static class AppAuthSetupData
    {
        public const string ListOfRolesWithPermissions = @"Role1: Permission1
Role2: Permission2
SuperRole: AccessAll";

        public static List<DefineUserWithRolesTenant> UsersRolesDefinition = new List<DefineUserWithRolesTenant>
        {
            new DefineUserWithRolesTenant("P1@g1.com", null, "Role1"),
            new DefineUserWithRolesTenant("P2@g1.com", null, "Role2"),
            new DefineUserWithRolesTenant("Super@g1.com", null, "SuperRole"),

        };
    }
}