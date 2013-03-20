UnbindTFS
=========

Removes the TFS bindinds from a C# Visual Studio project.
The application does the following steps to remove the TFS binding:
1. Edits the solution .sln files and removes these lines:
<pre>
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
</pre>

2. Edits the C# project files (.csproj) and removes these lines:
<pre>
   &lt;SccProjectName&gt;&lt;/SccProjectName&gt;
   &lt;SccLocalPath&gt;&lt;/SccLocalPath&gt;
   &lt;SccAuxPath&gt;&lt;/SccAuxPath&gt;
   &lt;SccProvider&gt;&lt;/SccProvider&gt;
</pre>
3. Removes all the .vssscc and .vspscc files.

Tha applcation has the abilitiy to ignore folders. So if you have you project on git with all the binding by providing '.git' it will ignore it.
