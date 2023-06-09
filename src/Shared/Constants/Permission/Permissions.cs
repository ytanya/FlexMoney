﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FlexMoney.Shared.Constants.Permission
{
    public static class Permissions
    {
        public static class Products
        {
            public const string View = "Permissions.Products.View";
            public const string Create = "Permissions.Products.Create";
            public const string Edit = "Permissions.Products.Edit";
            public const string Delete = "Permissions.Products.Delete";
            public const string Export = "Permissions.Products.Export";
            public const string Search = "Permissions.Products.Search";
        }

        public static class Brands
        {
            public const string View = "Permissions.Brands.View";
            public const string Create = "Permissions.Brands.Create";
            public const string Edit = "Permissions.Brands.Edit";
            public const string Delete = "Permissions.Brands.Delete";
            public const string Export = "Permissions.Brands.Export";
            public const string Search = "Permissions.Brands.Search";
        }

        public static class Types
        {
            public const string View = "Permissions.Types.View";
            public const string Create = "Permissions.Types.Create";
            public const string Edit = "Permissions.Types.Edit";
            public const string Delete = "Permissions.Types.Delete";
            public const string Export = "Permissions.Types.Export";
            public const string Search = "Permissions.Types.Search";
        }

        public static class Documents
        {
            public const string View = "Permissions.Documents.View";
            public const string Create = "Permissions.Documents.Create";
            public const string Edit = "Permissions.Documents.Edit";
            public const string Delete = "Permissions.Documents.Delete";
            public const string Search = "Permissions.Documents.Search";
        }

        public static class DocumentTypes
        {
            public const string View = "Permissions.DocumentTypes.View";
            public const string Create = "Permissions.DocumentTypes.Create";
            public const string Edit = "Permissions.DocumentTypes.Edit";
            public const string Delete = "Permissions.DocumentTypes.Delete";
            public const string Export = "Permissions.DocumentTypes.Export";
            public const string Search = "Permissions.DocumentTypes.Search";
        }

        public static class DocumentExtendedAttributes
        {
            public const string View = "Permissions.DocumentExtendedAttributes.View";
            public const string Create = "Permissions.DocumentExtendedAttributes.Create";
            public const string Edit = "Permissions.DocumentExtendedAttributes.Edit";
            public const string Delete = "Permissions.DocumentExtendedAttributes.Delete";
            public const string Export = "Permissions.DocumentExtendedAttributes.Export";
            public const string Search = "Permissions.DocumentExtendedAttributes.Search";
        }

        public static class Users
        {
            public const string View = "Permissions.Users.View";
            public const string Create = "Permissions.Users.Create";
            public const string Edit = "Permissions.Users.Edit";
            public const string Delete = "Permissions.Users.Delete";
            public const string Export = "Permissions.Users.Export";
            public const string Search = "Permissions.Users.Search";
        }

        public static class Roles
        {
            public const string View = "Permissions.Roles.View";
            public const string Create = "Permissions.Roles.Create";
            public const string Edit = "Permissions.Roles.Edit";
            public const string Delete = "Permissions.Roles.Delete";
            public const string Search = "Permissions.Roles.Search";
        }

        public static class RoleClaims
        {
            public const string View = "Permissions.RoleClaims.View";
            public const string Create = "Permissions.RoleClaims.Create";
            public const string Edit = "Permissions.RoleClaims.Edit";
            public const string Delete = "Permissions.RoleClaims.Delete";
            public const string Search = "Permissions.RoleClaims.Search";
        }

        public static class Communication
        {
            public const string Chat = "Permissions.Communication.Chat";
        }

        public static class Preferences
        {
            public const string ChangeLanguage = "Permissions.Preferences.ChangeLanguage";

            //TODO - add permissions
        }

        public static class Dashboards
        {
            public const string View = "Permissions.Dashboards.View";
        }

        public static class Hangfire
        {
            public const string View = "Permissions.Hangfire.View";
        }

        public static class AuditTrails
        {
            public const string View = "Permissions.AuditTrails.View";
            public const string Export = "Permissions.AuditTrails.Export";
            public const string Search = "Permissions.AuditTrails.Search";
        }

        public static class Members
        {
            public const string View = "Permissions.Members.View";
            public const string Create = "Permissions.Members.Create";
            public const string Edit = "Permissions.Members.Edit";
            public const string Delete = "Permissions.Members.Delete";
            public const string Export = "Permissions.Members.Export";
            public const string Search = "Permissions.Members.Search";
        }

        public static class MemberLines
        {
            public const string View = "Permissions.MemberLines.View";
            public const string Create = "Permissions.MemberLines.Create";
            public const string Edit = "Permissions.MemberLines.Edit";
            public const string Delete = "Permissions.MemberLines.Delete";
            public const string Export = "Permissions.MemberLines.Export";
            public const string Search = "Permissions.MemberLines.Search";
        }

        public static class MoneyLines
        {
            public const string View = "Permissions.MoneyLines.View";
            public const string Create = "Permissions.MoneyLines.Create";
            public const string Edit = "Permissions.MoneyLines.Edit";
            public const string Delete = "Permissions.MoneyLines.Delete";
            public const string Export = "Permissions.MoneyLines.Export";
            public const string Search = "Permissions.MoneyLines.Search";
        }

        public static class Transactions
        {
            public const string View = "Permissions.Transactions.View";
            public const string Create = "Permissions.Transactions.Create";
            public const string Edit = "Permissions.Transactions.Edit";
            public const string Delete = "Permissions.Transactions.Delete";
            public const string Export = "Permissions.Transactions.Export";
            public const string Search = "Permissions.Transactions.Search";
        }

        public static class Reports
        {
            public const string View = "Permissions.Reports.View";
            public const string Export = "Permissions.Reports.Export";
        }
        /// <summary>
        /// Returns a list of Permissions.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetRegisteredPermissions()
        {
            var permssions = new List<string>();
            foreach (var prop in typeof(Permissions).GetNestedTypes().SelectMany(c => c.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)))
            {
                var propertyValue = prop.GetValue(null);
                if (propertyValue is not null)
                    permssions.Add(propertyValue.ToString());
            }
            return permssions;
        }
    }
}