// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Container App Ingress configuration.</summary>
    public partial class Ingress
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIngress.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIngress.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIngress FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json ? new Ingress(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject into a new instance of <see cref="Ingress" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Ingress(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_stickySession = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("stickySessions"), out var __jsonStickySessions) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.IngressStickySessions.FromJson(__jsonStickySessions) : _stickySession;}
            {_corsPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("corsPolicy"), out var __jsonCorsPolicy) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.CorsPolicy.FromJson(__jsonCorsPolicy) : _corsPolicy;}
            {_fqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("fqdn"), out var __jsonFqdn) ? (string)__jsonFqdn : (string)_fqdn;}
            {_external = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonBoolean>("external"), out var __jsonExternal) ? (bool?)__jsonExternal : _external;}
            {_targetPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber>("targetPort"), out var __jsonTargetPort) ? (int?)__jsonTargetPort : _targetPort;}
            {_exposedPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber>("exposedPort"), out var __jsonExposedPort) ? (int?)__jsonExposedPort : _exposedPort;}
            {_transport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("transport"), out var __jsonTransport) ? (string)__jsonTransport : (string)_transport;}
            {_traffic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray>("traffic"), out var __jsonTraffic) ? If( __jsonTraffic as Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ITrafficWeight>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.App.Models.ITrafficWeight) (Microsoft.Azure.PowerShell.Cmdlets.App.Models.TrafficWeight.FromJson(__u) )) ))() : null : _traffic;}
            {_customDomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray>("customDomains"), out var __jsonCustomDomains) ? If( __jsonCustomDomains as Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ICustomDomain>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.App.Models.ICustomDomain) (Microsoft.Azure.PowerShell.Cmdlets.App.Models.CustomDomain.FromJson(__p) )) ))() : null : _customDomain;}
            {_allowInsecure = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonBoolean>("allowInsecure"), out var __jsonAllowInsecure) ? (bool?)__jsonAllowInsecure : _allowInsecure;}
            {_iPSecurityRestriction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray>("ipSecurityRestrictions"), out var __jsonIPSecurityRestrictions) ? If( __jsonIPSecurityRestrictions as Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIPSecurityRestrictionRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIPSecurityRestrictionRule) (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IPSecurityRestrictionRule.FromJson(__k) )) ))() : null : _iPSecurityRestriction;}
            {_clientCertificateMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("clientCertificateMode"), out var __jsonClientCertificateMode) ? (string)__jsonClientCertificateMode : (string)_clientCertificateMode;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Ingress" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Ingress" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._stickySession ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._stickySession.ToJson(null,serializationMode) : null, "stickySessions" ,container.Add );
            AddIf( null != this._corsPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._corsPolicy.ToJson(null,serializationMode) : null, "corsPolicy" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._fqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._fqdn.ToString()) : null, "fqdn" ,container.Add );
            }
            AddIf( null != this._external ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonBoolean((bool)this._external) : null, "external" ,container.Add );
            AddIf( null != this._targetPort ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber((int)this._targetPort) : null, "targetPort" ,container.Add );
            AddIf( null != this._exposedPort ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber((int)this._exposedPort) : null, "exposedPort" ,container.Add );
            AddIf( null != (((object)this._transport)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._transport.ToString()) : null, "transport" ,container.Add );
            if (null != this._traffic)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.XNodeArray();
                foreach( var __x in this._traffic )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("traffic",__w);
            }
            if (null != this._customDomain)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.XNodeArray();
                foreach( var __s in this._customDomain )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("customDomains",__r);
            }
            AddIf( null != this._allowInsecure ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonBoolean((bool)this._allowInsecure) : null, "allowInsecure" ,container.Add );
            if (null != this._iPSecurityRestriction)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.XNodeArray();
                foreach( var __n in this._iPSecurityRestriction )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("ipSecurityRestrictions",__m);
            }
            AddIf( null != (((object)this._clientCertificateMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._clientCertificateMode.ToString()) : null, "clientCertificateMode" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}