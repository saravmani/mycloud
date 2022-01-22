# Resharper Useful Tips
###### Discussion on Resharper and Some of it's tips and tricks
>

Code Editing
```
|   +-- File Header Text  *(To Setup the header for each file)*
|   +-- C# *(Can specify multiple project specific styles)*
|   |   +--Formatting Style *(Styles for Alignment, Breaks, Braces etc.,)*
```

##### Settings hierarchy
* 3 Levels are there - User Level, Team Level and Computer level
* User-level settings are saved into *sln.DotSettings.User* file. This has the highest precedence. *(Don't check-in to source control)*.
* Team Level settings are saved into *sln.DotSettings file*. This must be checked in
* User Level settings have
* You can find these settings under *ReSharper->Manage* Options settings

##### ReSharper pluggins
* ReSharper supports other plugins  on top of ReSharper. Also, we can develop our own plugin for ReSharper
* *ReSharper-> plugin Manager* is the marketplace to install the plugins

#### ReSharper Useful shortcuts
* ctrl+T -> Advanced any search option. Using this we can search anything Ex: Filename, Class, Methods, etc.,


[//]: # (Tags: Resharper Settings, Frequently Resharper Settings)
[//]: # (Type: Resharper - Settings)
[//]: # (Rating: 2)
[//]: # (Languages:powershell)
[//]: # (ReadyState:Publish)
