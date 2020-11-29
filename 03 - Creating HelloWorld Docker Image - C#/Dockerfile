#Create runtime docker image
FROM mcr.microsoft.com/dotnet/runtime:3.1
WORKDIR /App

#Expose port outside of container
EXPOSE 80

COPY ./HelloConsole/out .
ENTRYPOINT ["dotnet", "HelloConsole.dll"]