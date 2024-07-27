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

# Assuming the certificate is in the user's home directory under a specific path
COPY --from=build --chown=app:app $HOME/.aspnet/https/project3.pfx /app/project3.pfx

RUN dotnet publish "Project3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project3.dll", "--server.https=true", "--server.urls=https://0.0.0.0:5001"]