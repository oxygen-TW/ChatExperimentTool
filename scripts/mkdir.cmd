@Echo off
set total=40

rem 本區塊註解，不會執行
rem .
rem total 為資料夾的總數量，如欲修改請改數值，預設 20 個資料夾。
rem .
rem 本區塊註解，不會執行

for /L %%V in (1,1,%total%) do (
cls
echo.
echo.
echo 建立名稱為 %%V / %total% 的資料夾
MD Chat%%V
)

echo.
echo.
echo 建立完成，共計 %total% 個資料夾
pause