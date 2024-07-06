# simple-web-api-net-core

docker build -t simple-web-api:latest .

docker run -d -p 8080:8080 --name simple-web-api simple-web-api:latest

GET http://localhost:8080/Sum/Number1/5/Number2/6