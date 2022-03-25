# AspNet

- instalando o IWebHost
`
Install-Package Microsoft.AspNetCore -version 2.0.1
`

## Deixando a aplicação disponivel na web
-  new WebHostBuilder(); - classe responsavel por construir um hospedeiro web
-  UseKestrel() - esta dizendo ao webHost para construir a implementação do kestrel
-  UseStartup<Startup>() - comando responsavel por iniciar minha classe de nome Startup
-  build(); - cria uma implementação da interface webhost
-  Run(); - deixa meu objeto disponivel para receber requisições web

## Definindo uma resposta
  - classe Startup
  - criar um metodo que vai receber um tipo HttpContext. HttpContext toda informação especifica é armazenada ele, esse metodo retorna um Task
  - feito isso eu tenho que fazer uma requisições pipeline
## Propriedades http
  - resquest - traz uma serie de informação sobre a requisição
  - response - envia resposta aquela requisição
  
## Criando uma coleção de rotas
  - RouterBuilder() - recebe como argumento de entrada no seu construtor a aplicação que estamos configurando 
  - MapRoute() - recebe o dicionario, ou seja, as rotas
  - Build() - construi as rotas
  - UseRouter() - faz o rotiamento da coleção de rotas que acabei de criar
