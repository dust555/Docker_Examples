# 16 - DockerCompose ASP.NET using https

Create certificate in the certs folder
```
dotnet dev-certs https -ep .\myshop_csproj\certs\MyShop.pfx -p pw
```

Modify asp.env file to match certificate name and password




run container
```
docker-compose up
```


To get all cars
```
GET https://localhost:8001/api/cars
```
To add car:
```
POST {"manuf": "Ford", "model": "Mondeo"} to https://localhost:80010/api/cars
```
To get car by id
```
GET localhost:8000/api/cars/{id}
```
To update car:
```
PUT {"manuf": "Fiat", "model": "500"} to https://localhost:8001/api/cars/{id}
```
To delete car:
```
DELETE https://localhost:8001/api/cars/{id}
```