FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Balance-App/Balance-App.csproj", "Balance-App/"]
RUN dotnet restore "Balance-App/Balance-App.csproj"
COPY . .
WORKDIR "/src/Balance-App"
RUN dotnet build "Balance-App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Balance-App.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Balance-App.dll"]

