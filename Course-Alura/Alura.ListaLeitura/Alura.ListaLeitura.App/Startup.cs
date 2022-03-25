using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    internal class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // collection of routes
        public void Configure(IApplicationBuilder app)
        {

            var builder = new RouteBuilder(app);
            builder.MapRoute("Livros/ParaLer", LivrosParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLendo);
            builder.MapRoute("Livros/Lidos", LivrosLidos);
            builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", NovoLivro);
            builder.MapRoute("Livros/Detalhes/{id:int}", ExibeDetalhes);
            builder.MapRoute("Cadastro/NovoLivro", ExibirFormulario);
            builder.MapRoute("Cadastro/Incluir", ProcessaFormulario);

            var rotas = builder.Build();

            app.UseRouter(rotas);
        }

        // salvando resposta pelo formulario
        private Task ProcessaFormulario(HttpContext context)
        {
            var livro = new Livro()
            {
                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First() // assim pego informações do corpo
                //Autor = context.Request.Query["autor"].First() desta forma eu estou pegando s informações da url
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com sucesso");
        }


        // exibindo um formulario na tela
        private Task ExibirFormulario(HttpContext context)
        {
            var html = CarregaArquivoHTML("formulario");
            return context.Response.WriteAsync(html);
        }

        private string CarregaArquivoHTML(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }

        // metodo que pega pelo id
        public Task ExibeDetalhes(HttpContext context)
        {
            int id = Convert.ToInt32(context.GetRouteValue("id"));
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return context.Response.WriteAsync(livro.Detalhes());
        }


        // metodo para adicionar um novo livro
        private Task NovoLivro(HttpContext context)
        {
            var livro = new Livro()
            {
                Titulo = Convert.ToString(context.GetRouteValue("nome")), // name é o q eu coloquei na rota
                Autor = Convert.ToString(context.GetRouteValue("autor"))
            };

            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com sucesso");
        }

        //fazendo o roteamento do arquivo
        public Task Roteamento(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            var caminhoAtendidos = new Dictionary<string, RequestDelegate>
            {
                { "/Livros/ParaLer", LivrosParaLer },
                { "/Livros/Lendo", LivrosLendo },
                { "/Livros/Lidos", LivrosLidos }
            };

            if (caminhoAtendidos.ContainsKey(context.Request.Path)) // path pega p caminho
            {
                var metodo = caminhoAtendidos[context.Request.Path];
                return metodo.Invoke(context);
            }

            context.Response.StatusCode = 404;
            return context.Response.WriteAsync("Caminho inexistente.");

        }

        // escrevendo na tela
        private Task LivrosParaLer(HttpContext context)
        {
            var _rep = new LivroRepositorioCSV();
            var conteudoArquivo = CarregaArquivoHTML("para-ler");
            return context.Response.WriteAsync(conteudoArquivo);
        }

        // escrevendo na tela
        private Task LivrosLendo(HttpContext context)
        {
            var _rep = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_rep.Lendo.ToString());
        }

        // escrevendo na tela
        private Task LivrosLidos(HttpContext context)
        {
            var _rep = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_rep.Lidos.ToString());
        }
    }
}