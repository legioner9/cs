git remote add origin git@github.com:legioner9/cs.git
git remote add origin git@gitflic.ru:legioner9/cs.git

git clone git@gitflic.ru:legioner9/cs.git

git config --global user.email "legioner9@inbox.ru"
git config --global user.name "legioner9"

git remote add gh git@github.com:legioner9/cs.git
git remote add gf git@gitflic.ru:legioner9/cs.git


powershall git_bash
winget install --id Git.Git -e --source winget
winget install obsidian


"terminal.integrated.defaultProfile.windows": "Git Bash"


    eval "$(ssh-agent -s)"
    ssh-add ~/.ssh/id_rsa

install choco PwSh
@"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "[System.Net.ServicePointManager]::SecurityProtocol = 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"

~ $ wget https://raw.githubusercontent.com/legioner9/st_rc_d/refs/heads/master/.d/.install.ax/main_install_stl.sh
~ $ . main_install_stl.sh

~ $ wget https://gitflic.ru/project/legioner9/st_rc_d/blob/raw?file=.d%2F.install.ax%2Fmain_install_stl.sh
~ $ . main_install_stl.sh