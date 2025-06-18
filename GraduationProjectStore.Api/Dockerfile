# Use the .NET 8 SDK to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything and restore dependencies
COPY . .
RUN dotnet restore GraduationProjectStore.Api/GraduationProjectStore.API.csproj

# Build the app
RUN dotnet publish GraduationProjectStore.Api/GraduationProjectStore.API.csproj -c Release -o /app/publish

# Use the .NET 8 runtime to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Run the app
ENTRYPOINT ["dotnet", "GraduationProjectStore.API.dll"]
