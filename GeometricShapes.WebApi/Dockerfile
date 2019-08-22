FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["GeometricShapes.WebApi/GeometricShapes.WebApi.csproj", "GeometricShapes.WebApi/"]
COPY ["GeometricShapes.App/GeometricShapes.App.csproj", "GeometricShapes.App/"]
COPY ["GeometricShapes.Domain/GeometricShapes.Domain.csproj", "GeometricShapes.Domain/"]
COPY ["GeometricShapes.Infra/GeometricShapes.Infra.csproj", "GeometricShapes.Infra/"]
RUN dotnet restore "GeometricShapes.WebApi/GeometricShapes.WebApi.csproj"
COPY . .
WORKDIR "/src/GeometricShapes.WebApi"
RUN dotnet build "GeometricShapes.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GeometricShapes.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GeometricShapes.WebApi.dll"]
