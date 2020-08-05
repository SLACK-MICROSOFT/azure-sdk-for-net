// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ManagedIdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagedIdentityType
    {
        /// <summary>
        /// Indicates that system assigned identity is associated with the
        /// resource.
        /// </summary>
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        /// <summary>
        /// Indicates that user assigned identity is associated with the
        /// resource.
        /// </summary>
        [EnumMember(Value = "UserAssigned")]
        UserAssigned,
        /// <summary>
        /// Indicates that both system assigned and user assigned identity are
        /// associated with the resource.
        /// </summary>
        [EnumMember(Value = "SystemAssigned, UserAssigned")]
        SystemAssignedUserAssigned,
        /// <summary>
        /// Indicates that no identity is associated with the resource.
        /// </summary>
        [EnumMember(Value = "None")]
        None
    }
    internal static class ManagedIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ManagedIdentityType? value)
        {
            return value == null ? null : ((ManagedIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagedIdentityType value)
        {
            switch( value )
            {
                case ManagedIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ManagedIdentityType.UserAssigned:
                    return "UserAssigned";
                case ManagedIdentityType.SystemAssignedUserAssigned:
                    return "SystemAssigned, UserAssigned";
                case ManagedIdentityType.None:
                    return "None";
            }
            return null;
        }

        internal static ManagedIdentityType? ParseManagedIdentityType(this string value)
        {
            switch( value )
            {
                case "SystemAssigned":
                    return ManagedIdentityType.SystemAssigned;
                case "UserAssigned":
                    return ManagedIdentityType.UserAssigned;
                case "SystemAssigned, UserAssigned":
                    return ManagedIdentityType.SystemAssignedUserAssigned;
                case "None":
                    return ManagedIdentityType.None;
            }
            return null;
        }
    }
}