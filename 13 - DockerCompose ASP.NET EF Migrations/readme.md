# 13 - DockerCompose ASP.NET EF Migrations

running all docker containers in the docker-compose.yaml file in background, including a migrations container
```
docker-compose up -d
```


run EntityFramework migrations using the migrations container with sdk and ef-tools installed
```
docker exec -it migrations /root/.dotnet/tools/dotnet-ef database update
```

To get all cars
```
GET localhost:8000/api/cars
```
To add car:
```
POST {"manuf": "Ford", "model": "Mondeo"} to localhost:8000/api/cars
```
To get car by id
```
GET localhost:8000/api/cars/{id}
```
To update car:
```
PUT {"manuf": "Fiat", "model": "500"} to localhost:8000/api/cars/{id}
```
To delete car:
```
DELETE localhost:8000/api/cars/{id}
```