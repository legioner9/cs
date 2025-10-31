new console project

    $dotnet new console

powerShell adm

    $ [environment]::osversion
    $ dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart
    $ dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart

download  https://github.com/marchaesen/vcxsrv and install
path : \\wsl$

reinstall with files
    $ dotnet new console --force
Rewrite Program.cs

in Windows project:
git config --local core.autocrlf false

предоставляет UNIX-подобную среду разработки для Windows

installfrom :

for git
[git-scm.com](https://git-scm.com/install/windows)

for gtk
[msys2.org](https://www.msys2.org/)

for bash utils
[cygwin.com](https://cygwin.com/install.html) pack 

cli: ucrt.exe
Также надо добавить в переменные среды путь "C:\msys64\ucrt64\bin"
DO:: win+R, sysdm.cpl , дполнительно , переменные среды
set PATH=%PATH%;C:\msys64\ucrt64\bin


    $ pacman -S mingw-w64-ucrt-x86_64-gtk4
    $ pacman -S mingw-w64-ucrt-x86_64-toolchain base-devel
    $ brew install gtk4