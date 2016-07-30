using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"XamarinStudio.InsertDate",
	Namespace = "XamarinStudio.InsertDate",
	Version = "1.0"
)]

[assembly: AddinName("XamarinStudio.InsertDate")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("XamarinStudio.InsertDate")]
[assembly: AddinAuthor("wk")]


[assembly: AddinDependency("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly: AddinDependency("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]

