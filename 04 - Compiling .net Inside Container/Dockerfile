#Compiling project in container
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build_env
WORKDIR /App
COPY ./HelloConsole .
RUN dotnet restore
RUN dotnet publish -c Release -o out

#Create runtime docker image
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /App

COPY --from=build_env /App/out .
ENTRYPOINT ["dotnet", "HelloConsole.dll"]