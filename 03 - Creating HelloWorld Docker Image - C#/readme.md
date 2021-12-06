# 03 - Creating HelloWorld Docker Image - C#

compile project on local computer for release
```
dotnet publish -c Release -o out
```

creating image using Dockerfile
```
docker build -t <DockerID>/helloconsole .
```

running created image
```
docker run --name=helloconsole <DockerID>/helloconsole
```