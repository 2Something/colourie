[Files]
Source: "C:\Users\kalib\source\repos\colourie\bin\Debug\net9.0-windows\Colourie.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\kalib\source\repos\colourie\bin\Debug\net9.0-windows\Colourie.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\Downloads\dotnet-sdk-9.0.200-win-x64.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "..\bin\Debug\net9.0-windows\Colourie.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion

[Run]
Filename: "{tmp}\dotnet-sdk-9.0.200-win-x64.exe"; Parameters: "/quiet"; Check: NeedsDotNet9

[Code]
function NeedsDotNet9: Boolean;
var
  key: String;
begin
  key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v9.0';
  Result := not RegKeyExists(HKLM, key);
end;

[Icons]
Name: "{group}\Colourie"; Filename: "{app}\Colourie.exe"


[Setup]
AppName=Colourie
DefaultDirName={pf}\Colourie
DefaultGroupName=Colourie
OutputDir=.\
AppVersion=1.0
OutputBaseFilename=Colourie_Installer
Compression=lzma
SolidCompression=yes
VersionInfoCompany=Something
VersionInfoDescription=Color :)
AppId={{475C5FF9-990D-4F9C-970B-74CCD6BBD89F}
