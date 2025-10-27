#!/bin/bash

. "C:\YandexDisk\_repo\cs\.d\.sh\l.sh" &> ${HOME}/null

cd "C:\YandexDisk\_repo\cs\.d\.cs\EDU"

# l_02_dr2e @ | grep .name

# l_01_prs_f -ne "$(l_02_dr2e @ | grep .name)"

lst_pth="C:\YandexDisk\_repo\cs\.d\.cs\.lst\all_name_in_EDU_dir.lst"

: >${lst_pth}

for item in $(l_02_dr2e @ | grep .name); do
    l_01_prs_f -ne "${item}" >> ${lst_pth}
done

cat ${lst_pth}
echo
echo "cat ${lst_pth}"
