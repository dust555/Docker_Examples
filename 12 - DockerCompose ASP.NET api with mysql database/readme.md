# 12 - DockerCompose ASP.NET api with mysql database

running all docker containers in the docker-compose.yaml file
```
docker-compose up
```


running all docker containers in the docker-compose.yaml file in background
```
docker-compose up -d
```


stopping and removing all containers
```
docker-compose stop 
```


stopping and removing all containers
```
docker-compose down 
```


visit http://localhost:8000/api/cars


if the database and car table is not created, you will get an error:
MySql.Data.MySqlClient.MySqlException (0x80004005): Table 'myshopdb.Cars' doesn't exist

but connection to mysqlserver is ok