# AI - 01 - NLP Sentiment Analysis

## 01 - Train  
  
Train model in docker container using docker-compose  
creates logistic_clf.pkl file  
copy logistic_clf.pkl to 03 - Deploy folder
  

## 02 - Model
  
Trained model file  
  
## 03 - Deploy
  
Web application using the logistic_clf.pkl model file using docker-compose
  
visit http://localhost:5000 


## code source  

https://github.com/dmoonat/sentiment-analysis/tree/master/containerized_webapp  
  
## docker compose commands  
  
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