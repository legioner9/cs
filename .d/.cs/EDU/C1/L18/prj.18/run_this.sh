#!/bin/bash


PPWD=$(pwd)
echo "${PPWD}"
dr="C:\YandexDisk\_repo\cs\.d\.cs\EDU\C1\L18\prj.18"
cd ${dr} || return 1

echo -e "IN : ${dr}
dotnet run
"

dotnet run

cd "${PPWD}" || return 1
