# Asp.net
  
 - API WEB DO ASP.NET Core
  
## conexão com o mysql

### instalando o nuget
- ferramentas
- gerenciador de pacotes
- gerencia pacotes do nuget para a solução
- procurar
- primeiro pacote Microsoft.EntityFrameworkCore versão 5.0.5
- antes de instalar marcar o projeto que estamos utilizando
- segundo pacote microsft.EntityFrameworkCore.Tools
- terceiro pacote mysql.EntityFrameworkCore

## Organizando o projeto
- criar um nova pasta Data
- criar uma nova classe para fazer essa conexão nome movieContext
- pra falar que ele é um contexto da minha classe tem que herdar de DbContent
- criar um contrutor recebendo os paramentro "DbContextOptions MovieContext".DbContextOptions é minha opção e movieContext é o conceito que estou trabalhando
- criar uma prorpiedade DbSet Aqui eu coloco o objeto que eu quero mapear e acessar dentro do meu banco aqui o nome { get; set;} com esse dbset eu tenho acesso ao banco de dados da minha aplicação
 
 ## criando a string de conexão com o meu banco
 - appsettings.json - localizado abaixo do meu models
 - criar uma string de conexão abaixo de "AllowedHosts" cri uma string de conexão "connectionStrings":{
 "nome":"sevidor=localhost;nomeDoBanco=NomeQueEuQuiser;usuarioDoBanco=root;password=senha"
 }
 
 ## Na classe startup usar minha ConnectionString
 - dentro do metodo configureService
 services.AddDbContext<nomeDoMeuContexto>(opts => apts.UseMySql(Configuration.GetConnectionString("MovieFlixConnection")))
 
 ## integrando o meu banco coom minha aplicação
 - coloca o key em meu id
 - required
 - abrir o console do nuget
 - escrever Add-Migration nameDaMigração
 - para atualizar a mudança Update-Database
 
 
 ## Organizando minhas requisições Http
 - baixar o pacote AutoMapper.Extensions.Microsoft.dependencyInjection 8.1.1
 - como ele deve iniciar junto com a nossa aplicação vamos colocar ele no nosso startup
 - comando dentro do startup services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
 - para dizer a esse autoMapper que ele tem que converter minhas classe deve criar uma pasta de perfil dentro ela eu vou criar o MovieProfile minha classe vai herdar de Profile
 - criar um construtor
 - dentro do construtor deve criar os metodos, eu vou querer um map de que para que
 - metodo criado 
     - CreateMap<CreateMovieDTO, Movie>(); 
     - CreateMap<UpdateMovieDTO, Movie>(); 
     - CreateMap<Movie, MovieDTO>(); 
 - para utilizar preciso iniciar o meu automapper 
 - private IMapper variave no meu controller
 - dentro do meu construtor MovieController
   - meu construtor recebe um IMapper mapper
   - _mapper = mapper
 - pronto para utilizar
 - Movie movie = _mapper.Map<Movie>(movieDTO) - estou falando que quero converter o meu dto em um movie. Lembrado que movieDTO eu o nome da minha classe MovieDTO
 - Movie movie = _mapper.Map<MovieDTO>(filme) - estou falando que quero converter o meu fime para um dto 
 
 
