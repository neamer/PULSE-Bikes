# PULSE-Bikes

Seminarski iz predmeta RS2 2021/2022

docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=QWEasd123!" -p 1434:1433 -d mcr.microsoft.com/mssql/server:2019-latest

dotnet ef dbcontext scaffold "Data Source=localhost, 1434;Initial Catalog=PULSE; user=sa; Password=QWEasd123!" Microsoft.EntityFrameworkCore.SqlServer --output-dir Database

WINFORMS THEME

NAV BG - 19; 19; 29
CONTENT DARK BG - 39; 39; 49
PANEL LIGHT BG - 53; 53; 64
CONTENT DARK TEXT - 173; 173; 177
CONTENT LIGHT TEXT - 211; 211; 213
CONTENT LIGHT ACCENT LINE - 95; 95; 111

## ORDER STATES

    Cart - A cart state is created whenever the customer adds a item to their cart, no more than 1 draft state per customer
    Draft - A draft state is created whenever a employee adds a order through the desktop app
    Processed (Paid) - The user has paid the order
    Packed - The order is ready, and is awaiting shipment
    Shipped - The order has left the store and is on its way
    Collected - The customer picked up the order in the store
    Delivered
    Cancelled

## SERVICING STATES

    Initial - Default state, responsible for initializing the servicing
    Pending review - The servicing has been scheduled for review
    Pending payment - The mechanic has reviewed the bicycle and has determined the necessary parts and labour cost
    Pending servicing - The user has paid for the servicing offer
    Complete - The servicing has been completed and the bike is ready for pickup
    Canceled - The servicing could not be realised, the bike is ready for pickup

Order services planning

    Order header
    
change state after offer send

## ROLES

    Admin -
    Storekeeper - Bicycles, Parts, Gear, Brands
    Mechanic - Servicing, Parts, Brands
    Salesperson - Orders

    Everyone can view all but only certain roles can add/update/delete
