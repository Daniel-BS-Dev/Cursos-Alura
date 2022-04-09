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
- criar um contrutor recebendo o paramentro "DbContextOptions MovieContext".DbContextOptions é minha opção e movieContext é o conceito que estou trabalhando
- criar uma prorpiedade "DbSet Movie Movies{ get; set;}". DbSet vai mim dar o acesso a minha aplicação no banco de dados, movie é o nome a aplicação que quero acessar
 
 ## criando a string de conexão com o meu banco
 - appsettings.json - localizado abaixo do meu models
 - criar uma string de conexão abaixo de "AllowedHosts" criar uma string de conexão  "connectionStrings": { "TaskModelConnection":"server=localhost;database=taskModelDb;user=root;password=Da586310*"
}
- server - é o servidor da minha aplicação
- database - nome do meu bando de dados. nome que eu quiser
- user - usuario
- password - senha
 
 ## Na classe startup usar minha ConnectionString
 - dentro do metodo configureService
 services.AddDbContext<nomeDoMeuContexto>(opts => apts.UseMySql(Configuration.GetConnectionString("MovieFlixConnection")))
 
 ## integrando o meu banco coom minha aplicação
 - coloca o key em meu id
 - required
 - abrir o console do nuget
 - escrever Add-Migration nameDaMigração, esse nome pode ser qualquer nome da minha preferência
 - para atualizar a mudança Update-Database
 - no mysql para ver minha tabela criada "show databases". Para usar o banco criado "use nome do banco". Para mostrar minha tabela "show tables". Para ver os campos criados "desc nome da minha tabela"
 
 
 ## Organizando minhas requisições Http
 - baixar o pacote AutoMapper.Extensions.Microsoft.dependencyInjection 8.1.1
 - como ele deve iniciar junto com a nossa aplicação vamos colocar ele no nosso startup
 - comando dentro do startup services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
 - agora com um construtor eu posso iniciar esse mapper dentro da minha classe controller usando o tipo context criado antes
  
  ## Conversão de dados
 - para dizer a esse autoMapper que ele tem que converter minhas classee  devo criar uma pasta de perfil dentro dela eu vou criar a classe MovieProfile minha classe vai herdar de Profile
 - criar um construtor
 - dentro do construtor deve criar os metodos, eu vou querer um map de que para que
 - metodo criado 
     - CreateMap<CreateMovieDTO, Movie>(); 
     - CreateMap<UpdateMovieDTO, Movie>(); 
     - CreateMap<Movie, MovieDTO>(); 
 - para utilizar preciso iniciar o meu automapper 
 - private IMapper variavel no meu controller
 - dentro do meu construtor MovieController
   - meu construtor recebe um IMapper mapper
   - _mapper = mapper
 - pronto para utilizar
 - Movie movie = _mapper.Map<Movie>(movieDTO) - estou falando que quero converter o meu dto em um movie. Lembrado que movieDTO eu o nome da minha classe MovieDTO
 - Movie movie = _mapper.Map<MovieDTO>(filme) - estou falando que quero converter o meu fime para um dto 
 
 
