create network

docker network create mynetwork


Build python webserver image

docker build -t <DockerID>/pythonweb .


running created image mapping port 8000 of host to 5000 of container in mynetwork

docker run -d -p 8000:5000 --name=pythonweb --net=mynetwork <DockerID>/pythonweb



running mysql database server in mynetwork

docker run -d -it -v mysqldata:/var/lib/mysql --net=mynetwork -e MYSQL_ROOT_PASSWORD=pw -e MYSQL_DATABASE=db -e MYSQL_USER=user -e MYSQL_PASSWORD=pw --name mysqlserver mysql/mysql-server





visit http://localhost:8000

