// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for BackupLongTermRetentionPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackupLongTermRetentionPolicyState
    {
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Enabled")]
        Enabled
    }
    internal static class BackupLongTermRetentionPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this BackupLongTermRetentionPolicyState? value)  =>
            value == null ? null : ((BackupLongTermRetentionPolicyState)value).ToSerializedValue();

        internal static string ToSerializedValue(this BackupLongTermRetentionPolicyState value)
        {
            switch( value )
            {
                case BackupLongTermRetentionPolicyState.Disabled:
                    return "Disabled";
                case BackupLongTermRetentionPolicyState.Enabled:
                    return "Enabled";
            }
            return null;
        }

        internal static BackupLongTermRetentionPolicyState? ParseBackupLongTermRetentionPolicyState(this string value)
        {
            switch( value )
            {
                case "Disabled":
                    return BackupLongTermRetentionPolicyState.Disabled;
                case "Enabled":
                    return BackupLongTermRetentionPolicyState.Enabled;
            }
            return null;
        }
    }
}