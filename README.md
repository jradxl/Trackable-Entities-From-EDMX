Trackable-Entities-From-EDMX
============================

Trackable Entities From EDMX based on https://trackable.codeplex.com, but uses an EDMX file as the source.

To Build:
You will need my revised version of the T4 Toolbox. I have included the current DLL in the Libraries folder.
You will need Trackable Enities DLLs, but I have also included the current versions in the Libraries folder.
Both above cannot be sourced from NuGet.
If you need Trackable Enities DLLs then you will need to get from NuGet into another project, and then copy to this, or build the sources from codeplex.

The Domain Model project contains a stupid model demonstrating One2One, One2Many and Many2Many without a Payload.
The EDMX file is read by the Trackable Entities From EDMX project to build a similar set of Classes but inheriting from Trackable Entities. 
These are of course the DTOs to be used on the client side.

Sorry no tests or demos yet. Give me a chance.
Thanks to all the Codeplex projects I've been able to base this one on.

June 2013
JsrSoft.


