# PULSE-Bikes

Seminarski iz predmeta RS2 2021/2022

docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=QWEasd123!" -p 1434:1433 -d mcr.microsoft.com/mssql/server:2019-latest

dotnet ef dbcontext scaffold "Data Source=localhost, 1434;Initial Catalog=PULSE; user=sa; Password=QWEasd123!" Microsoft.EntityFrameworkCore.SqlServer --output-dir Database

TASKS

    Parts, Gear and Bicycles CRUD
    Forms app start, Staff login
    Product manipulation through forms
    product images implementation
