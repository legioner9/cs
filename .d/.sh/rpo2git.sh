#!/bin/bash

DDir=$(pwd)
cd "C:\YandexDisk\_repo\cs"

unset yes
read -rp "Revrite Snippets VSCode :: only 'y'" yes
if [ "y" == "$yes" ]; then
    rm -f ".d\.bcp_dpl\vs_code\Snippets"
    mkdir ".d\.bcp_dpl\vs_code\Snippets"
    cp "C:\Users\ProNout\AppData\Roaming\Code\User\snippets" ".d\.bcp_dpl\vs_code\Snippets"
fi

git add .
git commit -m "<>"
git push gf master
git push gh master

cd ${DDir}