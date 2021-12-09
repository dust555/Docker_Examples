# 13 - DockerCompose ASP.NET EF Migrations
**Create folder mysqldata on the level of docker-compose.yml file**
Mysql database is mounted to this folder

running all docker containers in the docker-compose.yaml file in background, including a migrations container
```
docker-compose up -d
```

This will create 3 containers:
> todo-api: Running the asp.net webapi on port 8000  
> todo-db: Running the mysql database mounted to the local folder mysqldata  
> todo-migrations: Running dotnet sdk with ef tools installed to update the database using the migrations


run EntityFramework migrations using the migrations container with sdk and ef-tools installed
```
docker exec -it todo-migrations /root/.dotnet/tools/dotnet-ef database update
```

## Testing

To get all todo
```
GET localhost:8000/api/todo
```
To add todo:
```
POST {"Title":"Sleep", "Urgency":"8"} to localhost:8000/api/todo
```
To get todo by id
```
GET localhost:8000/api/todo/{id}
```
To update todo:
```
PUT {"Title":"Sleep", "Urgency":"1"} to localhost:8000/api/todo/{id}
```
To delete todo:
```
DELETE localhost:8000/api/todo/{id}
```