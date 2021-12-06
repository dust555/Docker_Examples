# 02 - Creating HelloWorld Docker Image - Python

creating image using Dockerfile in this folder
```
docker build -t <DockerID>/hellopython .
```

running created image as a container
```
docker run --name=hellopython <DockerID>/hellopython
```


upload image to Docker Hub
```
docker push <DockerID>/hellopython
```