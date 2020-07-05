FROM mcr.microsoft.com/dotnet/core/sdk:3.1.100-buster AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
COPY *.xml ./
EXPOSE 3000/tcp
ENV ASPNETCORE_URLS=http://+:3000
ENTRYPOINT ["dotnet", "CalculaJurosAPI.dll"]