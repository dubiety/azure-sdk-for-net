// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// Extended UE Information Properties.
    /// Please note <see cref="ExtendedUEInfoProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="UEInfo4G"/> and <see cref="UEInfo5G"/>.
    /// </summary>
    public abstract partial class ExtendedUEInfoProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExtendedUEInfoProperties"/>. </summary>
        protected ExtendedUEInfoProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedUEInfoProperties"/>. </summary>
        /// <param name="ratType"> RAT Type. </param>
        /// <param name="lastReadOn"> The timestamp of last UE info read from the packet core (UTC). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedUEInfoProperties(RatType ratType, DateTimeOffset? lastReadOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RatType = ratType;
            LastReadOn = lastReadOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> RAT Type. </summary>
        internal RatType RatType { get; set; }
        /// <summary> The timestamp of last UE info read from the packet core (UTC). </summary>
        [WirePath("lastReadAt")]
        public DateTimeOffset? LastReadOn { get; set; }
    }
}
