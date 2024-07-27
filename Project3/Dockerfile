FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Project3/Project3.csproj", "./"]
RUN dotnet restore "Project3.csproj"
COPY ["Project3/", "./"]

RUN dotnet build "Project3.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet dev-certs https --trust
# Verify file existence and permissions
RUN ls -la /root/.aspnet/https/project3.pfx

# Conditional copy or wait for file existence
# Option 1: Conditional copy
# COPY --from=build --chown=app:app /root/.aspnet/https/project3.pfx /app/project3.pfx || true

# Option 2: Wait for file existence
RUN while [ ! -f /root/.aspnet/https/project3.pfx ]; do echo "Waiting for certificate..."; sleep 1; done
COPY --from=build --chown=app:app /root/.aspnet/https/project3.pfx /app/project3.pfx

RUN dotnet publish "Project3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project3.dll", "--server.https=true", "--server.urls=https://0.0.0.0:5001"]