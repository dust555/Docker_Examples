creating image using Dockerfile

docker build -t <DockerID>/apachewebserver .



running created image mapping port 8000 of host to 80 of container

docker run -p 8000:80 --name=webserver <DockerID>/apachewebserver

changing index.html in Websites folder will not be shown in new or running container




running image from docker hub mapping port 8000 of host to 80 of container and mounting ./Website to /usr/local/apache2/htdoc in container

docker run -p 8000:80 --mount type=bind,source="$(pwd)"/Website,target=/usr/local/apache2/htdocs --name=webserver httpd

changing index.html in Websites folder will be seen in new and running containers