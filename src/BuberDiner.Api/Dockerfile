#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/BuberDiner.Api/BuberDiner.Api.csproj", "src/BuberDiner.Api/"]
RUN dotnet restore "src/BuberDiner.Api/BuberDiner.Api.csproj"
COPY . .
WORKDIR "/src/src/BuberDiner.Api"
RUN dotnet build "BuberDiner.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuberDiner.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuberDiner.Api.dll"]