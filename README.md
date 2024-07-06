# simple-web-api-net-core

docker build -t fosouzadev/simple-web-api:1.0.0 .
docker build -t fosouzadev/simple-web-api:latest .

docker run -d -p 8080:8080 --name simple-web-api simple-web-api:latest

GET http://localhost:8080/Sum/Number1/5/Number2/6

Autenticar no docker hub
docker login

Enviar imagem
docker push fosouzadev/simple-web-api:1.0.0
docker push fosouzadev/simple-web-api:latest