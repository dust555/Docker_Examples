# 08 - Running persistent MySQL Server

Show available docker volumes
```
docker volume ls
```


Create volume
```
docker volume create mysqldbvolume
```



Running container mounting docker volume to container volume
> -v: mount docker volume to volume in container  
> -e: environment variable in container
```
docker run -it -v mysqldbvolume:/var/lib/mysql -p 8000:3306 -e MYSQL_ROOT_PASSWORD=pw --name mysqlserver -d mysql
```


connecting to mysql server
```
docker exec -it mysqlserver mysql -u root -p
```
OR

use local mysql with localhost and port 8000
```
mysql -h localhost -P 8000 -u root -p
```