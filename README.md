# Estudo de construção de imagem docker para Web Api

## Construir imagem
Utilizando o terminal, entre na pasta raiz do projeto e execute os seguintes comandos:
```
docker build -t fosouzadev/simple-web-api:1.0.0 .
docker build -t fosouzadev/simple-web-api:latest .
```

## Construir e executar container
Utilize o seguinte comando para criar e executar o container da aplicação:
```
docker run -d -p 8080:8080 --name simple-web-api simple-web-api:latest
```

## Requisição de teste
Faça uma requisição para o endpoint abaixo para testar o funcionamento da aplicação.
```
GET http://localhost:8080/Sum/Number1/5/Number2/6
```

## Autenticar no Docker Hub
Utilize o comando abaixo para se autenticar no Docker Hub via terminal:
```
docker login
```

## Enviar imagem para Docker Hub
Utilize os comandos abaixo para enviar a imagem para o Docker Hub:
```
docker push fosouzadev/simple-web-api:1.0.0
docker push fosouzadev/simple-web-api:latest
```