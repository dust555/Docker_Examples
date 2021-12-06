# 06 - ASP.NET Mock API webserver

creating image using Dockerfile
```
docker build -t <DockerID>/aspapi .
```

running created image mapping port 8000 of host to 80 of container
```
docker run -p 8000:80 --name=aspapi <DockerID>/aspapi
```

visit

http://localhost:8000/api/cars