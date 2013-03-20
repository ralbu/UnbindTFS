UnbindTFS
=========

Removes the TFS bindinds from a C# Visual Studio project.
The application does the following steps to remove the TFS binding:
1. Edits the solution .sln files and removes these lines:
GlobalSection(TeamFoundationVersionControl) = preSolution
   SccNumberOfProjects = 
   SccEnterpriseProvider = 
   SccTeamFoundationServer = 
   SccProjectUniqueName0 = 
   SccProjectName0 = 
   SccAuxPath0 = 
   SccLocalPath0 = 
   SccProvider0 = 
EndGlobalSection

2. Edits the C# project files (.csproj) and removes these lines:
<SccProjectName></SccProjectName>
<SccLocalPath></SccLocalPath>
<SccAuxPath></SccAuxPath>
<SccProvider></SccProvider>

3. Removes all the .vssscc and .vspscc files.

Tha applcation has the abilitiy to ignore folders. So if you have you project on git with all the binding by providing '.git' it will ignore it.
