using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"ResxTemplates", 
	Namespace = "ResxTemplates",
	Version = "0.1.1"
)]

[assembly:AddinName ("ResxTemplates")]
[assembly:AddinCategory ("IDE extensions")]
[assembly:AddinDescription ("ResxTemplates")]
[assembly:AddinAuthor ("calebmorris")]
[assembly:AddinDescription ("Resource file templates with different generators.")]

[assembly:ImportAddinFile ("Templates/EmptyResourceFileNoTool.xft.xml")]
[assembly:ImportAddinFile ("Templates/EmptyResourceFilePublic.xft.xml")]

