#!/bin/bash

. "C:\YandexDisk\_repo\cs\.d\.sh\l.sh" &> ${HOME}/null

cd "C:\YandexDisk\_repo\cs\.d\.cs\EDU"

# l_02_dr2e @ | grep .name

# l_01_prs_f -ne "$(l_02_dr2e @ | grep .name)"

lst_pth="C:\YandexDisk\_repo\cs\.d\.cs\.lst\all_name_in_EDU_dir.lst"

: >${lst_pth}
unset name
unset item

for item in $(l_02_dr2e @ | grep .name); do
    echo "${item}"
    name=$(l_01_prs_f -ne "${item}")
    excl="/c/YandexDisk/_repo/cs/.d/.cs/EDU/Ce02/"
    # str=${item|"/c/YandexDisk/_repo/cs/.d/.cs/EDU/Ce02//"||}
    if [ "NAME.name" != "${name}" ];then
        echo "${name}" >> ${lst_pth}
    fi
    
    # >> ${lst_pth}
done

cat ${lst_pth}
echo
echo "cat ${lst_pth}"
