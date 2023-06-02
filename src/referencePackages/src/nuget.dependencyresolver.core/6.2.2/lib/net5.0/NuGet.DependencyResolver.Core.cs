// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("NuGet.DependencyResolver.Core.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v5.0", FrameworkDisplayName = "")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyConfiguration("release")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("NuGet's PackageReference dependency resolver implementation.")]
[assembly: System.Reflection.AssemblyFileVersion("6.2.2.1")]
[assembly: System.Reflection.AssemblyInformationalVersion("6.2.2+027ca8b8ef4b4dc94995f87b9c441d2bcf742c1d.027ca8b8ef4b4dc94995f87b9c441d2bcf742c1d")]
[assembly: System.Reflection.AssemblyProduct("NuGet")]
[assembly: System.Reflection.AssemblyTitle("NuGet.DependencyResolver.Core")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/NuGet/NuGet.Client")]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Reflection.AssemblyVersionAttribute("6.2.2.1")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace NuGet.DependencyResolver
{
    public partial class AnalyzeResult<TItem>
    {
        public AnalyzeResult() { }

        public System.Collections.Generic.List<GraphNode<TItem>> Cycles { get { throw null; } }

        public System.Collections.Generic.List<DowngradeResult<TItem>> Downgrades { get { throw null; } }

        public System.Collections.Generic.List<VersionConflictResult<TItem>> VersionConflicts { get { throw null; } }

        public void Combine(AnalyzeResult<TItem> result) { }
    }

    public enum Disposition
    {
        Acceptable = 0,
        Rejected = 1,
        Accepted = 2,
        PotentiallyDowngraded = 3,
        Cycle = 4
    }

    public partial class DowngradeResult<TItem>
    {
        public DowngradeResult() { }

        public GraphNode<TItem> DowngradedFrom { get { throw null; } set { } }

        public GraphNode<TItem> DowngradedTo { get { throw null; } set { } }
    }

    public partial class GraphEdge<TItem>
    {
        public GraphEdge(GraphEdge<TItem> outerEdge, GraphItem<TItem> item, LibraryModel.LibraryDependency edge) { }

        public LibraryModel.LibraryDependency Edge { get { throw null; } }

        public GraphItem<TItem> Item { get { throw null; } }

        public GraphEdge<TItem> OuterEdge { get { throw null; } }
    }

    public sealed partial class GraphItemKeyComparer<T> : System.Collections.Generic.IEqualityComparer<GraphItem<T>>
    {
        public static GraphItemKeyComparer<T> Instance { get { throw null; } }

        public bool Equals(GraphItem<T> x, GraphItem<T> y) { throw null; }

        public int GetHashCode(GraphItem<T> obj) { throw null; }
    }

    public partial class GraphItem<TItem> : System.IEquatable<GraphItem<TItem>>
    {
        public GraphItem(LibraryModel.LibraryIdentity key) { }

        public TItem Data { get { throw null; } set { } }

        public bool IsCentralTransitive { get { throw null; } set { } }

        public LibraryModel.LibraryIdentity Key { get { throw null; } set { } }

        public bool Equals(GraphItem<TItem> other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }
    }

    public partial class GraphNode<TItem>
    {
        public GraphNode(LibraryModel.LibraryRange key) { }

        public Disposition Disposition { get { throw null; } set { } }

        public System.Collections.Generic.IList<GraphNode<TItem>> InnerNodes { get { throw null; } set { } }

        public GraphItem<TItem> Item { get { throw null; } set { } }

        public LibraryModel.LibraryRange Key { get { throw null; } set { } }

        public GraphNode<TItem> OuterNode { get { throw null; } set { } }

        public override string ToString() { throw null; }
    }

    public static partial class GraphOperations
    {
        public static AnalyzeResult<RemoteResolveResult> Analyze(this GraphNode<RemoteResolveResult> root) { throw null; }

        public static void Dump<TItem>(this GraphNode<TItem> root, System.Action<string> write) { }

        public static void ForEach<TItem>(this GraphNode<TItem> root, System.Action<GraphNode<TItem>> visitor) { }

        public static void ForEach<TItem>(this System.Collections.Generic.IEnumerable<GraphNode<TItem>> roots, System.Action<GraphNode<TItem>> visitor) { }

        public static void ForEach<TItem, TContext>(this GraphNode<TItem> root, System.Action<GraphNode<TItem>, TContext> visitor, TContext context) { }

        public static string GetId<TItem>(this GraphNode<TItem> node) { throw null; }

        public static string GetIdAndRange<TItem>(this GraphNode<TItem> node) { throw null; }

        public static string GetIdAndVersionOrRange<TItem>(this GraphNode<TItem> node) { throw null; }

        public static string GetPath<TItem>(this GraphNode<TItem> node) { throw null; }

        public static string GetPathWithLastRange<TItem>(this GraphNode<TItem> node) { throw null; }

        public static Versioning.NuGetVersion GetVersionOrDefault<TItem>(this GraphNode<TItem> node) { throw null; }

        public static Versioning.VersionRange GetVersionRange<TItem>(this GraphNode<TItem> node) { throw null; }

        public static bool IsPackage<TItem>(this GraphNode<TItem> node) { throw null; }

        public static GraphNode<TItem> Path<TItem>(this GraphNode<TItem> node, params string[] path) { throw null; }

        public static void ReleaseDowngradesDictionary(System.Collections.Generic.Dictionary<GraphNode<RemoteResolveResult>, GraphNode<RemoteResolveResult>> dictionary) { }

        public static System.Collections.Generic.Dictionary<GraphNode<RemoteResolveResult>, GraphNode<RemoteResolveResult>> RentDowngradesDictionary() { throw null; }
    }

    public partial interface IDependencyProvider
    {
        LibraryModel.Library GetLibrary(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework targetFramework);
        bool SupportsType(LibraryModel.LibraryDependencyTarget libraryTypeFlag);
    }

    public partial interface IRemoteDependencyProvider
    {
        bool IsHttp { get; }

        Configuration.PackageSource Source { get; }

        System.Threading.Tasks.Task<LibraryModel.LibraryIdentity> FindLibraryAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework targetFramework, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Versioning.NuGetVersion>> GetAllVersionsAsync(string id, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken token);
        System.Threading.Tasks.Task<LibraryModel.LibraryDependencyInfo> GetDependenciesAsync(LibraryModel.LibraryIdentity libraryIdentity, Frameworks.NuGetFramework targetFramework, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task<Packaging.IPackageDownloader> GetPackageDownloaderAsync(Packaging.Core.PackageIdentity packageIdentity, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken);
    }

    public partial class LibraryRangeCacheKey : System.IEquatable<LibraryRangeCacheKey>
    {
        public LibraryRangeCacheKey(LibraryModel.LibraryRange range, Frameworks.NuGetFramework framework) { }

        public Frameworks.NuGetFramework Framework { get { throw null; } }

        public LibraryModel.LibraryRange LibraryRange { get { throw null; } }

        public bool Equals(LibraryRangeCacheKey other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        public override string ToString() { throw null; }
    }

    public partial class LocalDependencyProvider : IRemoteDependencyProvider
    {
        public LocalDependencyProvider(IDependencyProvider dependencyProvider) { }

        public bool IsHttp { get { throw null; } }

        public Configuration.PackageSource Source { get { throw null; } }

        public System.Threading.Tasks.Task<LibraryModel.LibraryIdentity> FindLibraryAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework targetFramework, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }

        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Versioning.NuGetVersion>> GetAllVersionsAsync(string id, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }

        public System.Threading.Tasks.Task<LibraryModel.LibraryDependencyInfo> GetDependenciesAsync(LibraryModel.LibraryIdentity libraryIdentity, Frameworks.NuGetFramework targetFramework, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }

        public System.Threading.Tasks.Task<Packaging.IPackageDownloader> GetPackageDownloaderAsync(Packaging.Core.PackageIdentity packageIdentity, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }
    }

    public partial class LocalMatch : RemoteMatch
    {
        public LocalMatch() { }

        public LibraryModel.Library LocalLibrary { get { throw null; } set { } }

        public IDependencyProvider LocalProvider { get { throw null; } set { } }
    }

    public partial class LockFileCacheKey : System.IEquatable<LockFileCacheKey>
    {
        public LockFileCacheKey(Frameworks.NuGetFramework framework, string runtimeIdentifier) { }

        public string Name { get { throw null; } }

        public string RuntimeIdentifier { get { throw null; } }

        public Frameworks.NuGetFramework TargetFramework { get { throw null; } }

        public bool Equals(LockFileCacheKey other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }

        public override string ToString() { throw null; }
    }

    public static partial class PackagingUtility
    {
        public static LibraryModel.LibraryDependency GetLibraryDependencyFromNuspec(Packaging.Core.PackageDependency dependency) { throw null; }
    }

    public partial class RemoteDependencyWalker
    {
        public RemoteDependencyWalker(RemoteWalkContext context) { }

        public static bool IsGreaterThanOrEqualTo(Versioning.VersionRange nearVersion, Versioning.VersionRange farVersion) { throw null; }

        public System.Threading.Tasks.Task<GraphNode<RemoteResolveResult>> WalkAsync(LibraryModel.LibraryRange library, Frameworks.NuGetFramework framework, string runtimeIdentifier, RuntimeModel.RuntimeGraph runtimeGraph, bool recursive) { throw null; }
    }

    public partial class RemoteMatch : System.IEquatable<RemoteMatch>
    {
        public RemoteMatch() { }

        public LibraryModel.LibraryIdentity Library { get { throw null; } set { } }

        public string Path { get { throw null; } set { } }

        public IRemoteDependencyProvider Provider { get { throw null; } set { } }

        public bool Equals(RemoteMatch other) { throw null; }

        public override bool Equals(object obj) { throw null; }

        public override int GetHashCode() { throw null; }
    }

    public partial class RemoteResolveResult
    {
        public RemoteResolveResult() { }

        public System.Collections.Generic.List<LibraryModel.LibraryDependency> Dependencies { get { throw null; } set { } }

        public RemoteMatch Match { get { throw null; } set { } }
    }

    public partial class RemoteWalkContext
    {
        public RemoteWalkContext(Protocol.Core.Types.SourceCacheContext cacheContext, Configuration.PackageSourceMapping packageSourceMapping, Common.ILogger logger) { }

        public Protocol.Core.Types.SourceCacheContext CacheContext { get { throw null; } }

        public System.Collections.Concurrent.ConcurrentDictionary<LibraryRangeCacheKey, System.Threading.Tasks.Task<GraphItem<RemoteResolveResult>>> FindLibraryEntryCache { get { throw null; } }

        public bool IsMsBuildBased { get { throw null; } set { } }

        public System.Collections.Generic.IList<IRemoteDependencyProvider> LocalLibraryProviders { get { throw null; } }

        public System.Collections.Generic.IDictionary<LockFileCacheKey, System.Collections.Generic.IList<LibraryModel.LibraryIdentity>> LockFileLibraries { get { throw null; } }

        public Common.ILogger Logger { get { throw null; } }

        public Configuration.PackageSourceMapping PackageSourceMapping { get { throw null; } }

        public System.Collections.Generic.IList<IDependencyProvider> ProjectLibraryProviders { get { throw null; } }

        public System.Collections.Generic.IList<IRemoteDependencyProvider> RemoteLibraryProviders { get { throw null; } }

        public System.Collections.Generic.IList<IRemoteDependencyProvider> FilterDependencyProvidersForLibrary(LibraryModel.LibraryRange libraryRange) { throw null; }
    }

    public static partial class ResolverUtility
    {
        public static System.Threading.Tasks.Task<RemoteMatch> FindLibraryByVersionAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<IRemoteDependencyProvider> providers, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken token) { throw null; }

        public static System.Threading.Tasks.Task<GraphItem<RemoteResolveResult>> FindLibraryCachedAsync(System.Collections.Concurrent.ConcurrentDictionary<LibraryRangeCacheKey, System.Threading.Tasks.Task<GraphItem<RemoteResolveResult>>> cache, LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework framework, string runtimeIdentifier, RemoteWalkContext context, System.Threading.CancellationToken cancellationToken) { throw null; }

        public static System.Threading.Tasks.Task<GraphItem<RemoteResolveResult>> FindLibraryEntryAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework framework, string runtimeIdentifier, RemoteWalkContext context, System.Threading.CancellationToken cancellationToken) { throw null; }

        public static System.Threading.Tasks.Task<RemoteMatch> FindLibraryMatchAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework framework, string runtimeIdentifier, System.Collections.Generic.IEnumerable<IRemoteDependencyProvider> remoteProviders, System.Collections.Generic.IEnumerable<IRemoteDependencyProvider> localProviders, System.Collections.Generic.IEnumerable<IDependencyProvider> projectProviders, System.Collections.Generic.IDictionary<LockFileCacheKey, System.Collections.Generic.IList<LibraryModel.LibraryIdentity>> lockFileLibraries, Protocol.Core.Types.SourceCacheContext cacheContext, Common.ILogger logger, System.Threading.CancellationToken cancellationToken) { throw null; }

        public static System.Threading.Tasks.Task<System.Tuple<LibraryModel.LibraryRange, RemoteMatch>> FindPackageLibraryMatchCachedAsync(System.Collections.Concurrent.ConcurrentDictionary<LibraryModel.LibraryRange, System.Threading.Tasks.Task<System.Tuple<LibraryModel.LibraryRange, RemoteMatch>>> cache, LibraryModel.LibraryRange libraryRange, RemoteWalkContext remoteWalkContext, System.Threading.CancellationToken cancellationToken) { throw null; }

        public static System.Threading.Tasks.Task<RemoteMatch> FindProjectMatchAsync(LibraryModel.LibraryRange libraryRange, Frameworks.NuGetFramework framework, System.Collections.Generic.IEnumerable<IDependencyProvider> projectProviders, System.Threading.CancellationToken cancellationToken) { throw null; }
    }

    public partial class Tracker<TItem>
    {
        public Tracker() { }

        public System.Collections.Generic.IEnumerable<GraphItem<TItem>> GetDisputes(GraphItem<TItem> item) { throw null; }

        public bool IsAmbiguous(GraphItem<TItem> item) { throw null; }

        public bool IsBestVersion(GraphItem<TItem> item) { throw null; }

        public bool IsDisputed(GraphItem<TItem> item) { throw null; }

        public void MarkAmbiguous(GraphItem<TItem> item) { }

        public void Track(GraphItem<TItem> item) { }
    }

    public partial class VersionConflictResult<TItem>
    {
        public VersionConflictResult() { }

        public GraphNode<TItem> Conflicting { get { throw null; } set { } }

        public GraphNode<TItem> Selected { get { throw null; } set { } }
    }
}