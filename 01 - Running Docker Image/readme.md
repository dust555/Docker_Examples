# 01 - Running Docker Image from DockerHub

running an image from docker hub
```
docker run --name=ubuntu ubuntu
```


running an image keeping bash open
```
docker run -it --name=ubuntu ubuntu
```


running an image in background
```
docker run -it -d --name=ubuntu
```


run command on docker image
```
docker exec -i -t ubuntu bash
```