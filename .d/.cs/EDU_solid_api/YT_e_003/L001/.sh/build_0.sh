#!/bin/bash

cd "C:\YandexDisk\_repo\cs\.d\.cs\EDU_solid_api\YT_e_003\L001\prj" ||{
    echo die 1
    return 1
}

if ! [ -f "C:\YandexDisk\_repo\cs\.d\.cs\EDU_solid_api\YT_e_003\L001\prj" ];then
    dotnet new console
fi