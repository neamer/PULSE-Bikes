#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PULSE.Messenger/PULSE.Messenger.csproj", "PULSE.Messenger/"]
COPY ["PULSE.Model/PULSE.Model.csproj", "PULSE.Model/"]
RUN dotnet restore "PULSE.Messenger/PULSE.Messenger.csproj"
COPY . .
WORKDIR "/src/PULSE.Messenger"
RUN dotnet build "PULSE.Messenger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PULSE.Messenger.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PULSE.Messenger.dll"]