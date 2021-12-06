# 01 - Running Docker Image from DockerHub

running a container from an image on docker hub  
> --name: name of docker constainer
```
docker run --name=ubuntu ubuntu
```


running a container from an image on docker hub keeping the shell of the container open
> -i: keep STDIN open  
> -t: allocate a tty
```
docker run -it --name=ubuntu ubuntu
```


running a container from an image on docker hub in the background
> -d: detached
```
docker run -it -d --name=ubuntu
```


run command in docker container with name "ubuntu"
```
docker exec -it ubuntu bash
```