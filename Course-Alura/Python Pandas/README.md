# Python Pandas

## Documentação do pandas
- pandas.pydata.org

## Criando o arquivo
- conda create --name alura_pandas python=2.7 pandas=0.19.0 - colocar esse comando no prompt
- activate alura - ativando o ambiente
- python - entarndo no python
- import pandas - inportando o pandas
- pandas.__version__ - ver a versão
- exit() - sair do python
- deactivate - desativando o alura_pandas
- info --envs - ver informações do ambiente criado
- conda remove --name alura_pandas --all - destruindo o ambiente

## Usando a aplicação
- import pandas as pd
- dados = pd.read_csv("data/aluguel.csv", sep = ';') - sep = ';' como o meu arquivo esta separado por ; assim o meu pandas separa esse arquivo quando tiver um
- type(dados) - ver o tipo de variável
- dados.info() - ver informações
- dados.head(10) - mostrando os 10 primeiros
- shift + enter - eu salvo um titulo
- cell -> run all - roda tudo
- dados.dtypes - mostra as variaveis e os tipos
- pd.DataFrame(dados.dtypes) - mostrando os dados em um dataframe
- tipos_de_dados = pd.DataFrame(dados.dtypes, columns = ['Tipos de dados']) - nomeando a coluna do tipo de variavéis
- tipos_de_dados.columns.name = 'Variávies' - nomeando a coluna de variavies
- tipos_de_dados - ver a tabela formatada
- dados.shape - mostra os dois
- dados.shape[0] - mostra o total de linha
- dados.shape[1] - mostra o total de variaveis
- print('A base de dados apresenta {} registro (imóvies) e {} variáveis'.format(dados.shape[0], dados.shape[1])) -  imprimindo o total de linha e o total de variaveis

## Imprimindo o arquivo do tipo json
- json = open('data/aluguel.json')
- print(json.read()) - ver as 10 primmeiras observações
- df_json = pd.read_json('data/aluguel.json')
- df_json - ver em uma tabela

## Imprimindo o arquivo txt
- txt = open('data/aluguel.txt')
- print(txt.read())
- df_txt = pd.read_table('data/aluguel.txt')
- df_txt - importando para o pandas

## Imprimindo arquivo do tipo excel
- df_xlsx = pd.read_excel('data/aluguel.xlsx')
- df_xlsx

## Imprimindo o arquivo html
- df_html = pd.read_html('data/dados_html_1.html')
- df_html[0] - mostrando com dataFrame

## Imprimindo o arquivo html pela url
- df_html = pd.read_html('https://www.federalreserve.gov/releases/h3/current/default.html')

## Imprimindo informações de apenas uma coluna
- import pandas as pd
- dados = pd.read_csv('data/aluguel.csv', sep=';')
- dados['Tipo'] - mostrando informações da coluna tipo

## Ver o tipo de da coluna tipo
- tipo_de_imovel = dados['Tipo']
- type(tipo_de_imovel) - imprimindo o tipo

## Imprimindo as informações sem repetições
- tipo_de_imovel.drop_duplicates()

## Organizando a visualização
- tipo_de_imovel = pd.DataFrame(tipo_de_imovel)
- tipo_de_imovel - mostrando as informações do imovel
- tipo_de_imovel.index - organizando por index
- range(tipo_de_imovel.shape[0]) - Imprimi o range
- for i in range(tipo_de_imovel.shape[0]): print(i) - mostrando o range no for


## Imprimindo um Series
- import pandas as pd
- data = [1, 2, 3, 4, 5]
- s = pd.Series(data)

## Imprimindo um dicionario
- index = ['Linha' + str(i) for i in range(5)] - uam linha com 5 valores
- s = pd.Series(data = data, index = index) - mostrando informações

## Imprimindo um dicionario de outra maneira
- data = {'Linha' + str(i) : i + 1 for i in range(5)}
- s = pd.Series(data)
- s

## DataFrame
### Criando dataFrame simples
- data = [[1,2,3],[4,5,6],[7,8,9]]
- df1 = pd.DataFrame(data = data)
- df1
- index = ['Linha' + str(i) for i in range(3)] 
- df1 = pd.DataFrame(data = data, index = index) - nomeando as linhas

### Mudando os valores do df1
- df2[df1 > 0] = 'b'
- df2

- df3[df2 > 0] = 'c'
- df3

### Concatenando os valores
- df4 = pd.concat([df1,df2,df3]) - link por coluna
- df4 = pd.concat([df1,df2,df3], axis = 1) - link por linha

### criando uma list
- list(dados['Tipo'].drop_duplicates())

### criando uma siris
- dados['Tipo'].isin(residencial) - residencial é uma lista que eu criei
- list(dados_residencial['Tipo'].drop_duplicates()) - concatenando
- dados_residencial.shape[0]
- dados_residencial.index = range(dados_residencial.shape[0])

## Exportando a Base de dados
- dados_residencial.to_csv('dados/aluguel_residencial.csv', sep = ';', index = false)

## organizando dataframes
- data = [[1,2,3],[4,5,6],[7,8,9]] - criando um array
- data

- list('321') - faz uma listagem
- df = pd.dataFrame(data, list('321'), list('ZYX'))
- df.sort_index(inplace = true) - organizando pleo index da linha
- df.sort_index(inplace = true, axis = 1) - organizando pela coluna
- df.sort_index(by = 'X', inplace = true) - organizando pela coluna x
- df.sort_index(by = '3', inplace = true) - organizando pela coluna 3
- df.sort_index(by = ['X','Y'], inplace = true) - passando mais de um parametro

## Seleção e frequência
- selecao = dados['Tipo'] == 'Aparatamento' - pegando apenas os elementos do tipo apartamento
- n1 = dados[selecao].shape[0] - pegando o total
- selecao = (dados['Tipo'] == 'casa') | (dados['tipo'] == 'casa de condominio') | (dados['tipo'] == 'casa de vila') - selecionando os tipos casa, casa condominio e casa vila
- selecao = (dados['area' >= 60) & (dados <= 100) - os imovies com area entre 60 e 100 quadrados
- n3 = dados[selecao].shape[0]
- n3 - imprimindo o total
- selecao = (dados['quartos'] >=4) & (dados['valor'] < 2000) - selecione os imovies que tenham menos 4 quartos e aluguel menor que 2.000
- n4 = dados[selecao].shape[0]

## Formas de seleção
- 'l1 l2 l3'.split() - Cria um array com 3 posições
- data = [(1,2,3,4),(5,6,7)]
- df = pd.DataFrame(data, 'l1 l2 l3'.split(), 'c1 c2 c3'.split()) - Criando um dataFrame de 3 posições nomes das linhas l nome nas colunas c
- df['c1'] - pegando os valores da coluna 1
- df[['c3','c1']] - pegando a coluna 1 e 3
- df[:] - pegando todas as linhas
- df[1:] - pegando da linha 1 abaixo
- df[1:2] - pegando apenas a 1 linha
- df[1:][['c3','c1']] - apartir da linha 1 pegar o c3 e c1
- df.loc['l3'] - pegando a linha l3
- df.loc['l1','c2'] - pegando o valor que esta na coluna 2 linha 1
- df.iloc[0, 1] - pega a mesma coluna e linha atraves do index
- df.loc[['l3', 'l1'], ['c4','c1']] 

## Tratamento de dados faltantes
- dados.isnull() - marca a informação com true
- dados.null() - marca com false
- dados['valor'].isnull() - se o valor for no ele marca false

## Eliminando o ddos do arquivo
- a = dados.shape[0]
- dados.dropna(subset = ['valor'], inplace = true)
- b = dados.shape[0]
- a - b 
- dados[dados['condominio'].isnull()].shape[0] - pegando o numero de condominio nulos
- selecao = (dados['Tipo'] == 'Apartamento') & (dados['condominio'].isnull()) 
- dados.to_csv('daods/aluguel_residencial.csv', sep = ';', index = false) - substituindo o arquivo

## Metodos de interpolação
- data = [0.5, none, 0.52, none] 
- s = pd.Series(data)
- s.fillna(0) - preencher o valor com 0 
- s.fillna(method = 'ffill') - pega o posterior e adiciona no valor dele
- s.fillna(method = 'bfill') - pega o anterior
- s.fillna(s.mean()) - pega a media dos valores não nulos
- s.fillna(method = 'ffill', limit = 1) - vai preencher apenas o primeiro

## Criando novas variáveis
- dados['valor total'] = dados['valor'] + dados['condominio'] + dados['IPTU']
- dados['valor m2'] = dados['valor'] / dados['area']
- dados['valor m2'] = dados['valor m2'].around(2) - dividindo e obtendo o resultado com duas casas decimais

## excluindo variavies
- dados_aux = pd.DataFrame(dados[['tipo','valor',]])
- del dados_aux['valor'] - exclui
- dados_aux.pop('valor') - outra maneira 
- dados.drop(['valor', 'valor2'], axis = 1, inplace = true) - axis 1 quer dizer coluna axis 0 linha

## Contadores
- s = pd.Series(list('asddueuudj'))
- s.unique() - traz os elementos sem repetições
- s.value_counts() - conta o total de cada elemento

## Criando agrupamento
- dados['valor'].mean()

## Pegando apenas os bairros selecionados por mim
- bairros = ['barra da tijuca','copancabana','ipanema','botafogo']
- selecao = dados['Bairro'].isin(bairros)
- dados = dados[selecao]
- dados['Bairro'].drop_duplicates()

## ver onde ele encontrou estes bairro
- grupo_bairro = dados.groupby('Bairro')
- grupo_bairro.groups 

## Pegando a media do meu valor
- grupo_bairro['valor'].mean()
- grupo_bairro['valor','condominio'].mean(),round()

## Estatistica descritivas
- grupo_bairro['valor'].decribe().round(2)
- grupo_bairro['valor'].aggregate(['min','max','sum']) - pegando os parametros agregados
