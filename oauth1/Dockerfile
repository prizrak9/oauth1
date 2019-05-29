FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["oauth1/oauth1.csproj", "oauth1/"]
RUN dotnet restore "oauth1/oauth1.csproj"
COPY . .
WORKDIR "/src/oauth1"
RUN dotnet build "oauth1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "oauth1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "oauth1.dll"]