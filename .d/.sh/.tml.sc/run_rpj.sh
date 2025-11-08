#!/bin/bash

PPWD=$(pwd)

cd "PATH_TO_PRJ"

cli="dotnet run" 

echo -e " in $(pwd)
RUN::
${cli}"

${cli}

cd "${PPWD}"