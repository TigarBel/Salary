; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B51D3393-801D-4E89-B6DE-269B21B9FF86}}        
AppName=Salary Program
AppVersion=1.0
AppPublisher=MySoftWare
DefaultDirName={pf}\Salary Program
DisableProgramGroupPage=yes
OutputBaseFilename=Setup Salary Program
SetupIconFile=D:\Salary\_png.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\Option3.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\Option3.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Salary\Option3\ApplicationLoader\bin\Release\ApplicationLoader.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\Salary Program"; Filename: "{app}\Salary.exe"
Name: "{commondesktop}\Salary Program"; Filename: "{app}\ApplicationLoader";IconFilename: "D:\Salary\_png.ico"; Tasks: desktopicon

[Registry]
Root: HKCU; Subkey: "Software\MySoftWare"; Flags: uninsdeletekeyifempty
Root: HKCU; Subkey: "Software\MySoftWare\Program"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\MySoftWare"; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: "Software\MySoftWare\Salary Program"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\MySoftWare\Program\Settings"; ValueType: string; ValueName: "InstallPath"; ValueData: "{app}"