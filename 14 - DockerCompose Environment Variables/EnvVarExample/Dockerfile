#Selecting .net sdk base image from docker hub
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build_env
WORKDIR /App
COPY *.csproj .
RUN dotnet restore
COPY . .


RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /App
COPY --from=build_env /App/out .
ENTRYPOINT ["dotnet", "EnvVarExample.dll"]