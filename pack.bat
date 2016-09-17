
echo 包搜索字符串
echo %1
echo 项目方案地址
echo %2
echo 包名称
set nupkg=""
echo 删除历史包
del %1 /f /q /a 
echo 打包
nuget Pack %2 -Build -Properties Configuration=Release