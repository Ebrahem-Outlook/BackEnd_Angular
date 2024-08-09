#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/BackEnd.API/BackEnd.API.csproj", "src/BackEnd.API/"]
COPY ["src/BackEnd.Infrastructure/BackEnd.Infrastructure.csproj", "src/BackEnd.Infrastructure/"]
COPY ["src/BackEnd.Application/BackEnd.Application.csproj", "src/BackEnd.Application/"]
COPY ["src/BackEnd.Domain/BackEnd.Domain.csproj", "src/BackEnd.Domain/"]
RUN dotnet restore "./src/BackEnd.API/BackEnd.API.csproj"
COPY . .
WORKDIR "/src/src/BackEnd.API"
RUN dotnet build "./BackEnd.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BackEnd.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackEnd.API.dll"]