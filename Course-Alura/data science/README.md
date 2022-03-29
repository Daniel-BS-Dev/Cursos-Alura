# Data Science

## documentação
- pandas dataframe docs

## Maquina que estamos usando

- link da maquina na nuvem - https://colab.research.google.com/drive
- Link da biblioteca de filmes - https://grouplens.org/datasets/movielens/latest

## Lendo arquivo CSV com a biblioteca pandas

- importando a biblioteca pandas - import pandas as pd
- lendo o arquivo - pd.read_csv("ratings.csv") .obs: entre os parenteses eu coloco o caminho do arquivo

## Comandos
- notas = pd.read_csv("ratings") - estou atribuindo minhas informações a variavel notas
- notas.head() - estou pegando os cinco primeiro dados
- notas.shape - buscando informações da tabela

## Renomeando minhas colunas
- notas.columns = ["usuarioId","filmesId","notas"
,"momento"]

## imprimindo os valores 
- notas["notas"] - imprimindo todos os valores de notas
- notas["notas"].unique() - imprimindo dados unicos
- notas["notas"].value_counts() - imprimindo os valores
- notas["notas"].mean() - pegando a media das notas
- notas["notas"].median() - pegando a media que esta no meio
- notas["notas"].describe() - pegando diversas medidas de descrição

## Mostrando um grafico de notas
- notas.head()
- notas.notas.plot()

## Criando um grafico com informações uteis
- notas.head()
- notas.notas.plot(kind='hist')

## Utilizando a biblioteca seaborn as sns
- import seaborn as sns - importando o seaborn
- sns.boxplot(notas.notas) - pegando os dados em um grafico

## Pegando informações do filme 1
- notas.query("filmeId==1") - informacões do filme 1
- notas.query("filmeId==1").notas - pegando apenas as notas
- notas.query("filmeId==1").notas.mean() - pegando a media das notas

## Pegando a media das notas de cada filme
- notas.groupby("filmeId").mean() - agrupando os filmes
- notas.groupby("filmeId").mean()["nota"] - extraindo apenas a coluna notas 
- medias_por_filme.plot(kind='hist') - mostrando a media em grafico 

## Usando o seaborn pra ver as medias
- sns.distplot(medias_por_filme) - mostrando informações das medias pelo grafico
- sns.distplot(medias_por_filme, bins=10) - trazendo as informações com restrição de bins
- sns.boxplot(y=medias_por_filme) - mostarndo as informações na vertical


## Importando a biblioteca matplotlib
- import matplotlib.pyplot as plt
-  plt.hist(medias_por_filme) - mostrando o grafico nesta biblioteca
-  plt.title("Histograma das medias dos filmes") - colocando um titulo no meu grafico

## Usando o seaborn junto com o matplotlib
- plt.figure(figsize=(5,8))
- sns.boxplot(y=medias_por_filme)

## Imprimindo apenas as linguagens
- tmdb.original_language.unique() - essa é outra maneira de pegar apenas a coluna language
- tmdb["original_language"].value_counts() - estou contando que cada linguagem aparece
- tmdb["original_language"].value_counts().index - trazendo apenas os index
- tmdb["original_language"].value_counts().value - trazendo apenas o valor
- tmdb["original_language"].value_counts().to_frame - transformando meus dados em uma tabela zebrada
-  tmdb["original_language"].value_counts().to_frame().reset_index() - colocando o index na minha tabela

## Usando o grafico de barra do seaborn para ver os dados de categoria
sns.barplot(data = tmdb) - mostarndo o grafico na tela

## Criando um grafico de barra para as linguagens
contagem_de_lingua = tmdb["original_language"].value_counts().to_frame().reset_index()
contagem_de_lingua.columns = ["original_language","total"]
contagem_de_lingua.head()
sns.barplot(x="original_language", y="total", data = contagem_de_lingua)

## Forma mais facil de fazer o grafico
- !pip install seaborn==0.9.0 - instalando a versõ do seaborn
- print(sns.__version__) - versão atual
- sns.catplot(x = "original_language", kind="count", data = tmdb) - imprimindo o grafico

## Usando o grafico de pizza
- plt.pie(contagem_de_lingua["total"], labels = contagem_de_lingua["original_language"])

## Algumas funções adicionais
- total_por_lingua = tmdb["original_language"].value_counts()
- total_geral = total_por_lingua.sum() - pegando o total geral
- total_de_ingles = total_por_lingua.loc["en"] - total 
- total_do_resto = total_geral - total_de_ingles - total do resto

## Criando duas barras de grafico
- sns.barplot(x="lingua", y="total", data = dados)

## Trazendo só a lingua inglês
- tmdb.query("original_language == 'en'") - trazendo os dados da lingua inglês
- total_de_lingua_de_outro_filmes = tmdb.query("original_language != 'en'").original_language.value_counts() - trazendo o total de diferentes do inglês 

## Imprimindo em um grafico
- filmes_sem_lingua_original = tmdb.query("original_language != 'en'")
- sns.catplot(x = "original_language", kind="count", data = filmes_sem_lingua_original_em_inglês)

## Organizando o grafico
- sns.catplot(x = "original_language", kind="count", data = filmes_sem_lingua_original_em_ingles
- aspect = 2 - assim o meu grafico vai crescer
- palette = "GnBu_d", - usando uma cor mais forte para o valor mais alto e mais clara para um valor mais baixo

## pegando informações de um filme especifico
- notas_do_filme_toy_story = notas.query("filmeId==1") - pegando o filme toy story
- notas_do_jumanji = notas.query("filme==2") - pegando informações do jumanji
- print(len(notas_do_toy_story), len(notas_do_jumanji))
- pint("Nota media do Toy Story %.2f" % notas_do_toy_story.nota.mean()) - pegando a media do filme com arredondamento de duas casas decimais
- order = total_de_lingua_de_outro_filmes.index) - organizando por index ou seja valor

## Juntando dois parametros
- import numpy as np
- filme1 = np.append(np.array[2.5] * 10), np.([3.5] * 10))
- filme2 = np.append(np.array([5] * 10), np.array[1] * 10))
- print(filme1.mean(), filme2.mean()) - imprimindo a media dos filmes
- print(np.median(filme1)) - imprimindo a mediana
- sns.displot(filme1) - mostrando o grafico do fime 1
- plt.hist(filme1) - mostrando outro tipo de grafico
- sns.boxplot(filme1) - mostrando outro tipo de grafico
- plt.boxplot([filme1, filme2]) - mostrando as informações dos dois graficos 
- sns.boxplot(x = "flimeId", y = "nota", data = notas.query("filmeId in [ 1,2,3,5]")) - mostarndo um grafico dos cinco filmes
- notas_do_jumanji.nota.std() - pegando o desvio padrão 



