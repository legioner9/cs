#!/bin/bash

DDir=$(pwd)
cd "C:\YandexDisk\_repo\cs"

git add .
git commit -m "<>"
git push gf master
git push gh master

cd ${DDir}