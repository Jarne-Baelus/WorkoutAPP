FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ./project/ ./
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /App
COPY --from=build /App./
ENTRYPOINT ["dotnet", "project.dll"]