running 2 containers in the default 'bridge' network

docker run -itd --name=ubuntu1 ubuntu
docker run -itd --name=ubuntu2 ubuntu


listing networks

docker network ls



getting network information

docker network inspect bridge



logging in to ubuntu1 container

docker exec -it ubuntu1 bash



Installing ping on ubuntu1

apt update
apt install iputils-ping -y

You can ping to ubuntu2 using it's ip address, not by using the hostname ubuntu2



create network

docker network create mynetwork



running container in specific network

docker run -itd --net=mynetwork --name=ubuntu1 ubuntu
docker run -itd --net=mynetwork --name=ubuntu2 ubuntu


getting network information

docker network inspect mynetwork



now you can ping from ubuntu1 to ubuntu2 using the hostname ubuntu2