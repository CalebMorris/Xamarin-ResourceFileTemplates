using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"ResxTemplates", 
	Namespace = "ResxTemplates",
	Version = "0.1.0"
)]

[assembly:AddinName ("ResxTemplates")]
[assembly:AddinCategory ("IDE extensions")]
[assembly:AddinDescription ("ResxTemplates")]
[assembly:AddinAuthor ("calebmorris")]

[assembly:ImportAddinFile ("Templates/EmptyResourceFileNoTool.xft.xml")]
[assembly:ImportAddinFile ("Templates/EmptyResourceFilePublic.xft.xml")]

