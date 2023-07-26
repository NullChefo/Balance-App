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

# FROM build AS publish
# RUN dotnet publish "Balance-App.csproj" -c Release -o /app/publish /p:UseAppHost=false

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "Balance-App.dll"]


FROM build AS publish
# /p:UseAppHost=false
# -p:PublishAot=true
RUN dotnet publish "Balance-App.csproj" -c Release -o /app/publish  -r linux-musl-x64 --self-contained true /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true /p:DeleteExistingFiles=true /p:TrimUnusedDependencies=true -p:PublishTrimmed=true -p:PublishReadyToRun=true -p:StripSymbols=false


FROM alpine:latest

RUN apk add --no-cache \
    ca-certificates \
    # .NET Core dependencies
    krb5-libs libgcc libintl libssl1.1 zlib \
    libstdc++ lttng-ust tzdata userspace-rcu
 
# Enable detection of running in a container
ENV DOTNET_RUNNING_IN_CONTAINER=true
 
# Set the invariant mode since icu_libs isn't included (see https://github.com/dotnet/announcements/issues/20)
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["./Balance-App"]
