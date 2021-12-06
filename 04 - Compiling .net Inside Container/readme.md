# 04 - Compiling .net Inside Container

creating image using Dockerfile
```
docker build -t <DockerID>/helloconsole .
```

running created image
```
docker run --name=helloconsole <DockerID>/helloconsole
```