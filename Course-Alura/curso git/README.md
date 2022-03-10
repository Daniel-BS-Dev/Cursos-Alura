# Git

- git init - Inicializa um repositório no diretório em que o comando for executado. A partir deste comando, o Git poderá gerenciar as modificações realizadas nos arquivos.
- git add index.html - Adiciona o projeto HTML
- git add . - Adiciona todos os projetos na pasta
- git rm - Remove o arquivo
- git commit -m "" - Salvar uma mensagem
- git status - Informações do git
- git log - Mostra diversas informações
- git config --local - Cada projeto
- git config --global - O projeto como um todo
- git config --local user.name "vinicius Dias" - Modificando o nome
- git config user.email - ver o email
- git log -p - ver todas as informações incluindo mudanças no projeto
- git log --author="nameDoAutor" - Mostra os gits feitos pelo autor
- git log --pretty="format:%H" - Mostra apenas o resh
- git log --pretty="format:%H %s %ae" - Mostra apenas o resh, messagem e autor
- .gitignore - Pasta criada para o git igonorar 
- git remote -v - mostra o endereço do local
- git clone 

## Criando um repositorio remoto
## Na pasta servidor 
- git init --bare - Vai servir para armazenar as alterações, só contém as alterações. Não contém copia

### Adicionando um repositorio remoto na pasta daniel
- git remote add 'name' 'caminho'
