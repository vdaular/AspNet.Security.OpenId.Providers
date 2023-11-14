﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenId.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Http;

namespace AspNet.Security.OpenId.Events;

public class OpenIdRedirectContext(HttpContext context,
    AuthenticationScheme scheme,
    OpenIdAuthenticationOptions options,
    AuthenticationProperties properties,
    OpenIdAuthenticationMessage message) : PropertiesContext<OpenIdAuthenticationOptions>(context, scheme, options, properties)
{
    /// <summary>
    /// Gets or sets the protocol message that has been generated by the handler up to this point.
    /// </summary>
    public OpenIdAuthenticationMessage ProtocolMessage { get; set; } = message;
}
