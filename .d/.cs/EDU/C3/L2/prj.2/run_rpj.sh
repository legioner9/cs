#!/bin/bash

PPWD=$(pwd)

cd "/c/YandexDisk/_repo/cs/.d/.cs/EDU/C3/L2/prj.2"

cli="dotnet run" 

echo -e " in $(pwd)
RUN::
${cli}"

${cli}

cd "${PPWD}"