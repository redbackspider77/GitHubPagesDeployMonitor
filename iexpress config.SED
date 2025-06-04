[Version]
Class=IEXPRESS
SEDVersion=3
[Options]
PackagePurpose=InstallApp
ShowInstallProgramWindow=0
HideExtractAnimation=0
UseLongFileName=0
InsideCompressed=0
CAB_FixedSize=0
CAB_ResvCodeSigning=0
RebootMode=N
InstallPrompt=%InstallPrompt%
DisplayLicense=%DisplayLicense%
FinishMessage=%FinishMessage%
TargetName=%TargetName%
FriendlyName=%FriendlyName%
AppLaunched=%AppLaunched%
PostInstallCmd=%PostInstallCmd%
AdminQuietInstCmd=%AdminQuietInstCmd%
UserQuietInstCmd=%UserQuietInstCmd%
SourceFiles=SourceFiles
[Strings]
InstallPrompt=
DisplayLicense=
FinishMessage=
TargetName=C:\Users\Kuzma\Desktop\Visual Studio\GitHubDeployMonitor\install files\Github Pages Deploy Monitor.EXE
FriendlyName=Github Pages Deploy Monitor
AppLaunched=msiexec /i "GITHUB~1.msi"
PostInstallCmd=cmd /c msiexec /i "MyApp.msi" /qn && start "" "C:\Program Files (x86)\redbackspider69\Github Pages Deploy Monitor\GitHubDeployMonitor.exe"
AdminQuietInstCmd=
UserQuietInstCmd=
FILE0="Github Pages Deploy Monitor.msi"
[SourceFiles]
SourceFiles0=C:\Users\Kuzma\Desktop\Visual Studio\GitHubDeployMonitor\Github Pages Deploy Monitor\Release\
[SourceFiles0]
%FILE0%=
