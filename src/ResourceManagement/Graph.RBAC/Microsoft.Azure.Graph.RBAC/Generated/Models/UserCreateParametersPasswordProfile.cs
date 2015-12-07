// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class UserCreateParametersPasswordProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UserCreateParametersPasswordProfile class.
        /// </summary>
        public UserCreateParametersPasswordProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// UserCreateParametersPasswordProfile class.
        /// </summary>
        public UserCreateParametersPasswordProfile(string password, bool? forceChangePasswordNextLogin = default(bool?))
        {
            Password = password;
            ForceChangePasswordNextLogin = forceChangePasswordNextLogin;
        }

        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Force change password on next login
        /// </summary>
        [JsonProperty(PropertyName = "forceChangePasswordNextLogin")]
        public bool? ForceChangePasswordNextLogin { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}