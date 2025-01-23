namespace Microsoft.ComponentDetection.Detectors.NuGet;

using System;
using global::NuGet.Frameworks;

/// <summary>
/// Framework packages for net9.0.
/// </summary>
internal partial class FrameworkPackages
{
    internal static class NETCoreApp90
    {
        private static NuGetFramework Net90 { get; } = new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCoreApp, new Version(9, 0));

        internal static FrameworkPackages Instance { get; } = new(Net90, FrameworkNames.NetCoreApp, NETCoreApp80.Instance)
        {
            { "Microsoft.VisualBasic", "10.4.0" },
            { "System.Buffers", "5.0.0" },
            { "System.Collections.Immutable", "9.0.0" },
            { "System.Diagnostics.DiagnosticSource", "9.0.0" },
            { "System.Formats.Asn1", "9.0.0" },
            { "System.Formats.Tar", "9.0.0" },
            { "System.IO.Pipelines", "9.0.0" },
            { "System.Memory", "5.0.0" },
            { "System.Net.Http.Json", "9.0.0" },
            { "System.Numerics.Vectors", "5.0.0" },
            { "System.Private.Uri", "4.3.2" },
            { "System.Reflection.DispatchProxy", "6.0.0" },
            { "System.Reflection.Metadata", "9.0.0" },
            { "System.Runtime.CompilerServices.Unsafe", "7.0.0" },
            { "System.Text.Encoding.CodePages", "9.0.0" },
            { "System.Text.Encodings.Web", "9.0.0" },
            { "System.Text.Json", "9.0.0" },
            { "System.Threading.Channels", "9.0.0" },
            { "System.Threading.Tasks.Dataflow", "9.0.0" },
            { "System.Threading.Tasks.Extensions", "5.0.0" },
            { "System.Xml.XPath.XDocument", "5.0.0" },
        };

        internal static FrameworkPackages AspNetCore { get; } = new(Net90, FrameworkNames.AspNetCoreApp, NETCoreApp80.AspNetCore)
        {
            { "Microsoft.AspNetCore", "9.0.0" },
            { "Microsoft.AspNetCore.Antiforgery", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication.BearerToken", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication.Cookies", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication.Core", "9.0.0" },
            { "Microsoft.AspNetCore.Authentication.OAuth", "9.0.0" },
            { "Microsoft.AspNetCore.Authorization", "9.0.0" },
            { "Microsoft.AspNetCore.Authorization.Policy", "9.0.0" },
            { "Microsoft.AspNetCore.Components", "9.0.0" },
            { "Microsoft.AspNetCore.Components.Authorization", "9.0.0" },
            { "Microsoft.AspNetCore.Components.Endpoints", "9.0.0" },
            { "Microsoft.AspNetCore.Components.Forms", "9.0.0" },
            { "Microsoft.AspNetCore.Components.Server", "9.0.0" },
            { "Microsoft.AspNetCore.Components.Web", "9.0.0" },
            { "Microsoft.AspNetCore.Connections.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.CookiePolicy", "9.0.0" },
            { "Microsoft.AspNetCore.Cors", "9.0.0" },
            { "Microsoft.AspNetCore.Cryptography.Internal", "9.0.0" },
            { "Microsoft.AspNetCore.Cryptography.KeyDerivation", "9.0.0" },
            { "Microsoft.AspNetCore.DataProtection", "9.0.0" },
            { "Microsoft.AspNetCore.DataProtection.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.DataProtection.Extensions", "9.0.0" },
            { "Microsoft.AspNetCore.Diagnostics", "9.0.0" },
            { "Microsoft.AspNetCore.Diagnostics.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Diagnostics.HealthChecks", "9.0.0" },
            { "Microsoft.AspNetCore.HostFiltering", "9.0.0" },
            { "Microsoft.AspNetCore.Hosting", "9.0.0" },
            { "Microsoft.AspNetCore.Hosting.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Hosting.Server.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Html.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Http", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Connections", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Connections.Common", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Extensions", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Features", "9.0.0" },
            { "Microsoft.AspNetCore.Http.Results", "9.0.0" },
            { "Microsoft.AspNetCore.HttpLogging", "9.0.0" },
            { "Microsoft.AspNetCore.HttpOverrides", "9.0.0" },
            { "Microsoft.AspNetCore.HttpsPolicy", "9.0.0" },
            { "Microsoft.AspNetCore.Identity", "9.0.0" },
            { "Microsoft.AspNetCore.Localization", "9.0.0" },
            { "Microsoft.AspNetCore.Localization.Routing", "9.0.0" },
            { "Microsoft.AspNetCore.Metadata", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.ApiExplorer", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Core", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Cors", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.DataAnnotations", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Formatters.Json", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Formatters.Xml", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Localization", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.Razor", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.RazorPages", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.TagHelpers", "9.0.0" },
            { "Microsoft.AspNetCore.Mvc.ViewFeatures", "9.0.0" },
            { "Microsoft.AspNetCore.OutputCaching", "9.0.0" },
            { "Microsoft.AspNetCore.RateLimiting", "9.0.0" },
            { "Microsoft.AspNetCore.Razor", "9.0.0" },
            { "Microsoft.AspNetCore.Razor.Runtime", "9.0.0" },
            { "Microsoft.AspNetCore.RequestDecompression", "9.0.0" },
            { "Microsoft.AspNetCore.ResponseCaching", "9.0.0" },
            { "Microsoft.AspNetCore.ResponseCaching.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.ResponseCompression", "9.0.0" },
            { "Microsoft.AspNetCore.Rewrite", "9.0.0" },
            { "Microsoft.AspNetCore.Routing", "9.0.0" },
            { "Microsoft.AspNetCore.Routing.Abstractions", "9.0.0" },
            { "Microsoft.AspNetCore.Server.HttpSys", "9.0.0" },
            { "Microsoft.AspNetCore.Server.IIS", "9.0.0" },
            { "Microsoft.AspNetCore.Server.IISIntegration", "9.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel", "9.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Core", "9.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes", "9.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Transport.Quic", "9.0.0" },
            { "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets", "9.0.0" },
            { "Microsoft.AspNetCore.Session", "9.0.0" },
            { "Microsoft.AspNetCore.SignalR", "9.0.0" },
            { "Microsoft.AspNetCore.SignalR.Common", "9.0.0" },
            { "Microsoft.AspNetCore.SignalR.Core", "9.0.0" },
            { "Microsoft.AspNetCore.SignalR.Protocols.Json", "9.0.0" },
            { "Microsoft.AspNetCore.StaticAssets", "9.0.0" },
            { "Microsoft.AspNetCore.StaticFiles", "9.0.0" },
            { "Microsoft.AspNetCore.WebSockets", "9.0.0" },
            { "Microsoft.AspNetCore.WebUtilities", "9.0.0" },
            { "Microsoft.Extensions.Caching.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Caching.Memory", "9.0.0" },
            { "Microsoft.Extensions.Configuration", "9.0.0" },
            { "Microsoft.Extensions.Configuration.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Configuration.Binder", "9.0.0" },
            { "Microsoft.Extensions.Configuration.CommandLine", "9.0.0" },
            { "Microsoft.Extensions.Configuration.EnvironmentVariables", "9.0.0" },
            { "Microsoft.Extensions.Configuration.FileExtensions", "9.0.0" },
            { "Microsoft.Extensions.Configuration.Ini", "9.0.0" },
            { "Microsoft.Extensions.Configuration.Json", "9.0.0" },
            { "Microsoft.Extensions.Configuration.KeyPerFile", "9.0.0" },
            { "Microsoft.Extensions.Configuration.UserSecrets", "9.0.0" },
            { "Microsoft.Extensions.Configuration.Xml", "9.0.0" },
            { "Microsoft.Extensions.DependencyInjection", "9.0.0" },
            { "Microsoft.Extensions.DependencyInjection.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Diagnostics", "9.0.0" },
            { "Microsoft.Extensions.Diagnostics.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Diagnostics.HealthChecks", "9.0.0" },
            { "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Features", "9.0.0" },
            { "Microsoft.Extensions.FileProviders.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.FileProviders.Composite", "9.0.0" },
            { "Microsoft.Extensions.FileProviders.Embedded", "9.0.0" },
            { "Microsoft.Extensions.FileProviders.Physical", "9.0.0" },
            { "Microsoft.Extensions.FileSystemGlobbing", "9.0.0" },
            { "Microsoft.Extensions.Hosting", "9.0.0" },
            { "Microsoft.Extensions.Hosting.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Http", "9.0.0" },
            { "Microsoft.Extensions.Identity.Core", "9.0.0" },
            { "Microsoft.Extensions.Identity.Stores", "9.0.0" },
            { "Microsoft.Extensions.Localization", "9.0.0" },
            { "Microsoft.Extensions.Localization.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Logging", "9.0.0" },
            { "Microsoft.Extensions.Logging.Abstractions", "9.0.0" },
            { "Microsoft.Extensions.Logging.Configuration", "9.0.0" },
            { "Microsoft.Extensions.Logging.Console", "9.0.0" },
            { "Microsoft.Extensions.Logging.Debug", "9.0.0" },
            { "Microsoft.Extensions.Logging.EventLog", "9.0.0" },
            { "Microsoft.Extensions.Logging.EventSource", "9.0.0" },
            { "Microsoft.Extensions.Logging.TraceSource", "9.0.0" },
            { "Microsoft.Extensions.ObjectPool", "9.0.0" },
            { "Microsoft.Extensions.Options", "9.0.0" },
            { "Microsoft.Extensions.Options.ConfigurationExtensions", "9.0.0" },
            { "Microsoft.Extensions.Options.DataAnnotations", "9.0.0" },
            { "Microsoft.Extensions.Primitives", "9.0.0" },
            { "Microsoft.Extensions.WebEncoders", "9.0.0" },
            { "Microsoft.JSInterop", "9.0.0" },
            { "Microsoft.Net.Http.Headers", "9.0.0" },
            { "System.Diagnostics.EventLog", "9.0.0" },
            { "System.Security.Cryptography.Pkcs", "8.0.1" },
            { "System.Security.Cryptography.Xml", "9.0.0" },
            { "System.Threading.RateLimiting", "9.0.0" },
        };

        internal static FrameworkPackages WindowsDesktop { get; } = new(Net90, FrameworkNames.WindowsDesktopApp, NETCoreApp80.WindowsDesktop)
        {
            { "System.Configuration.ConfigurationManager", "8.0.1" },
            { "System.Diagnostics.EventLog", "8.0.1" },
            { "System.Diagnostics.PerformanceCounter", "8.0.1" },
            { "System.Drawing.Common", "8.0.10" },
            { "System.IO.Packaging", "8.0.1" },
            { "System.Security.Cryptography.Pkcs", "8.0.1" },
            { "System.Security.Cryptography.Xml", "8.0.2" },
        };

        internal static void Register() => FrameworkPackages.Register(Instance, AspNetCore, WindowsDesktop);
    }
}
