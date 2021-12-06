# 05 - Python webserver

creating image using Dockerfile
```
docker build -t <DockerID>/pythonweb .
```

running created image mapping port 8000 of host to 5000 of container
> -p: mapping localhost port to port in docker container
```
docker run -p 8000:5000 --name=pythonweb <DockerID>/pythonweb
```

visit http://localhost:5000