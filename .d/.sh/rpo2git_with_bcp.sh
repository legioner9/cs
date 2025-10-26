#!/bin/bash

DDir=$(pwd)
cd "C:\YandexDisk\_repo\cs"

echo -e "${ECHO_TRUE}Rewrite Snippets VSCode :: only 'y'${NRM}"
unset yes
read -r yes
if [ "y" == "$yes" ]; then
    rm -rf ".d\.bcp_dpl\vs_code\Snippets"
    mkdir ".d\.bcp_dpl\vs_code\Snippets"
    cp -r "C:\Users\ProNout\AppData\Roaming\Code\User\snippets" ".d\.bcp_dpl\vs_code\Snippets"
fi

git add .
git commit -m "<>"
git push gf master
git push gh master

cd ${DDir}