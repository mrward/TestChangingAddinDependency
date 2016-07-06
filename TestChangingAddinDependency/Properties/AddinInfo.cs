using Mono.Addins;

[assembly:Addin ("TestChangingAddinDependency",
	Namespace = "MonoDevelop",
	Version = "0.2",
	Category = "IDE extensions")]

[assembly:AddinName ("TestChangingAddinDependency")]
[assembly:AddinDescription ("Test Changing Addin Dependency.")]

[assembly:AddinDependency ("Core", "6.0")]
[assembly:AddinDependency ("Ide", "6.0")]
[assembly:AddinDependency ("UnitTesting", "6.0")]