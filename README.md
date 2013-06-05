Trackable-Entities-From-EDMX
============================

Trackable Entities From EDMX based on https://trackable.codeplex.com, but uses an EDMX file as the source.

Version 1.0.0.1 2013-06-06
Use the folder "TrackableEntitiesClientServerFromEdmx"
Now has both Client and Server side templates.
The Domain Model project has been removed.
The Model EDMX is now in the TrackableEntitiesServerFromEdmx project.
Notice that TrackableEntitiesClientFromEdmx has no reference to EntityFramework, and neither project references each other.
But as yet, no tests.
Have fun!


To Build:
You will need my revised version of the T4 Toolbox. You will need to download and build this, and then load the VSIX if you
want to run the T4 Template, but I have included the current VSIX in the Libraries folder for your convenience.
(I've not tested this fully... Both versions of the T4 Toolbox are on my own PC and have not caused me problems)

You will need Trackable Enities DLLs, but I have also included the current versions in the Libraries folder.
Both above cannot be sourced from NuGet.
If you need Trackable Enities DLLs then you will need to get from NuGet into another project, and then copy to this, or build the sources from codeplex.

The Domain Model project contains a stupid model demonstrating One2One, One2Many and Many2Many without a Payload.
The EDMX file is read by the Trackable Entities from EDMX project to build a similar set of Classes but inheriting from Trackable Entities. 
These are of course the DTOs to be used on the client side.

Sorry no tests or demos yet. Give me a chance.
Thanks to all the Codeplex projects I've been able to base this one on.

June 2013
JsrSoft.


