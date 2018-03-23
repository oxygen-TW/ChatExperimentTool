rem 127.0.0.1;7000;7001;https://web.oxygentw.net/api/ChatExperiment/api.php;Chat01;Chat02;20
rem 需動態 ip myName Name
 
set port1=7000
set port2=7001
set API_EntryPoint=https://web.oxygentw.net/api/ChatExperiment/api.php
set limit=20
set ip=127.0.0.1
set myName=Chat01
set Name=Chat02
set config-name=config.ini

echo %ip%;%port1%;%port2%;%API_EntryPoint%;%myName%;%Name%;%limit% > %config-name%
echo ok
pause