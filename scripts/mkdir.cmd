@Echo off
set total=40

rem ���϶����ѡA���|����
rem .
rem total ����Ƨ����`�ƶq�A�p���ק�Ч�ƭȡA�w�] 20 �Ӹ�Ƨ��C
rem .
rem ���϶����ѡA���|����

for /L %%V in (1,1,%total%) do (
cls
echo.
echo.
echo �إߦW�٬� %%V / %total% ����Ƨ�
MD Chat%%V
)

echo.
echo.
echo �إߧ����A�@�p %total% �Ӹ�Ƨ�
pause