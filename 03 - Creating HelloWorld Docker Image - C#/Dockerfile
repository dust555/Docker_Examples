#Create runtime docker image
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /App

COPY ./HelloConsole/out .
ENTRYPOINT ["dotnet", "HelloConsole.dll"]