FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /ensi/movies_dotnet
COPY ["movies.api/movies.api.csproj", "movies.api/"]
RUN dotnet restore "movies.api/movies.api.csproj"
COPY . .
WORKDIR "/ensi/movies_dotnet/movies.api"
RUN dotnet build "movies.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "movies.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Set the environment variable for database connection
ENV DB_CONNECTION_STRING="Server=172.26.169.238,1433;Database=MovieDb;User Id=sa;Password=yourStrong(!)Password;TrustServerCertificate=true;"
ENTRYPOINT ["dotnet", "movies.api.dll"]