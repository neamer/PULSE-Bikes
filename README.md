# PULSE-Bikes

Seminarski iz predmeta RS2 2021/2022

docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=QWEasd123!" -p 1434:1433 -d mcr.microsoft.com/mssql/server:2019-latest

dotnet ef dbcontext scaffold "Data Source=localhost, 1434;Initial Catalog=PULSE; user=sa; Password=QWEasd123!" Microsoft.EntityFrameworkCore.SqlServer --output-dir Database

WINFORMS THEME

NAV BG - 19, 19, 29
CONTENT DARK BG - 39, 39, 49
PANEL LIGHT BG - 53, 53, 64
CONTENT DARK TEXT - 173; 173; 177
CONTENT LIGHT TEXT - 211, 211, 213
CONTENT LIGHT ACCENT LINE - 95, 95, 111
