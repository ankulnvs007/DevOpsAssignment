#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Devops.API/Devops.API.csproj", "Devops.API/"]
RUN dotnet restore "Devops.API/Devops.API.csproj"
COPY . .
WORKDIR "/src/Devops.API"
RUN dotnet build "Devops.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Devops.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Devops.API.dll"]