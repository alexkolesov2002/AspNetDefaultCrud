FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Crud.Host/Crud.Host.csproj", "Crud.Host/"]
RUN dotnet restore "Crud.Host/Crud.Host.csproj"
COPY . .
WORKDIR "/src/Crud.Host"
RUN dotnet build "Crud.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crud.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crud.Host.dll"]
