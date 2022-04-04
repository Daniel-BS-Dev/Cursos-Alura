# Machine Learning
## Obtendo duas classes de animais 
- caracteristicas
   - (not = 1, yes = 0)
    - pelo longo
    - perna curta
    - faz auau
- atribuindo as caracteristicas aos animais
  - pig1=[1, 0, 1]
  - pig2=[1, 0, 0]
  - pig3=[1, 1, 0]

  - dog1=[0, 1, 1]
  - dog2=[1, 0, 1]
  - dog3=[1, 1, 1]

- atribuindo dados
  - data = [pig1, pig2, pig3, dog1, dog2, dog3]
- separando por classe
  - 1 => pig, 0 => dog
  - classes = [1,1,1,0,0,0]

- Importando um estimador para diferenciar as classes
  - from sklearn.svm import LinearSVC
  - model = LinearSVC()
  - model.fit(data) - passando meu dados e as classes

- falando para minha maquina pegar um animal misterioso
  - unknown_animal = [1,1,1] - tem pelo logo, tem perna curta e faz auau
  - model.predict([unknown_animal]) - dizendo ao minha maquina pra ela prever esse animal pra mim, resultado é 0 como eu separei minha classe 1 e 0

- Prevendo mais de uma classes
  - unknown1 = [1,1,1]
  - unknown2 = [1,1,0]
  - unknown3 = [0,1,1]
  - tests = [unknown1,unknown2,unknown3]
  - model.predict(test) 

- Obtendo a taxa de acerto
  -  previous = model.predict(tests)  
  -  resultado do meu teste - test_classes =  [0,1,1]

- Comparando minha classes com meus teste_classe
  - previous == tests_classes

- Numero de total verdadeiro
  - result_test =  [0,1,1]
  - previous == result_test
  - corect = (previous == result_test).sum()
  - print(corect)

- Tamanho de test
  - total = len(tests)

- taxa de acertos 
  - tax_corect = (corect/total)

- taxa de acertos em porcentagem
  - tax_corect = (corect/total * 100) 

- Biblioteca do sklearn para calcular a taxa de acerto
  - from sklearn.metrics import accuracy_score
 
 - se imprimindo um resultado em casa decimais
  - print("taxa de acerto %.2f" % (corect/total * 100))

## Introdução ao Machine learn
- Lendo o arquivo csv
  - import pandas as pd
  - uri = "https://gist.githubsercontent.com/guilhermesilva/2d2e" - caminha do meu arquivo 
  - data = pd.read_csv(uri)
  - data.head()

- separando as colunas da minha tabela
  - x = data[["home","how_it"works","contact"]] - dentro do meu array de data eu declaro a minha lista de coluna
  - y = data["bought"] - imprimindo apenas a coluna de nome bought

- Renomeando minhas colunas
 - mapa = {"home" : "principal", "how_it_works" : "como_funciona"}data.rename(columns = mapa)

- numero de linha e colunas
  - data.shape 

- pegando os elementos
  - tain_x = x[:75] - pegando do meu x até 75 elementos. De 0 a 74
  - tain_y = y[:75] - pegando do meu y até 75 elementos
  - test_x = x[75:] - pegando do meu x apartir 75 elementos. de 75 a 100
  - est_y = y[75:] - pegando do meu y apartir 75 elementos. de 75 a 100

- from sklearn.svm import LinearSvc
  - modelo = LinearSVC()
  - modelo.fit(train_x, train_y)
  - previsoes = modelo.predict(train_x) - modelo prever pra mim basiado no train_x

- pegando a taxa de acertos
 - from sklearn.metrics import accuracy_score
 - acuracia = accuracy_score(teste_y, previsoes)
 - print("A acuracia foi %.2f%%" % accuracia)

- separando o train e o test
  - from sklearn.model_selection import train_test_split
  - traino_x, teste_x, traino_y, teste_y = train_test_split(x, y, test_size = 0.25) - aqui eu vou passar as duas matrizes x e y, o tamanho do teste. Ele vai retorna train x e y e test x e y. declarando desde jeito eu não preciso fazer a declaração a cima x[:75]...
  - print("Treinaremos com %d elementos e testaremos com %d elementos" % (len(treino_x), len(teste_x)))

- exemplo de como fica
  - from sklearn.model_selection import train_test_split
  - from sklearn.svm import LinearSVC
  - from sklearn.metrics import accuracy_score
  - SEED = 20 - numero declaro por o meu resultado fica variando a cada busca
  - treino_x, teste_x, treino_y, teste_y = train_test_split(x, y, random_state = SEED, test_size = 0.25, stratify = y) - aqui eu uso o meu random state, o stratify e falando a minha maquina para ela stratificar de acordo com o y assim eu tenho uma aproximidade nas duas tabelas
  - print("Treinaremos com %d elementos e testaremos com %d elementos" % (len(treino_x), len(teste_x)))
  - modelo = LinearSVC()
  - modelo.fit(train_x, train_y)
  - previsoes = modelo.predict(train_x)
  acuracia = accuracy_score(teste_y, previsoes)
 - print("A acuracia foi %.2f%%" % accuracia)

- Buscando o total de 0 e 1 do y
  - treino_y.value_counts()

- Invertendo valores
  - troca = {
  - 0 : 1,
  - 1 : 0
  - } dados.nao_finalizado.map(trocar) - na minha coluna não finalizado ele vai trocar o 1 para 0 e o 0 para 1
  - dados.tail() - ultimos elementos

- criando o grafico
  - import seaborn as sns
  - sns.scatterplot(x="horas_separadas", y="preco", data=dados)
  - !pip install saeborn=0.9.0 - atualizando o meu seaborn essa deve ser uma declaração no começo do projeto
   - sns.scatterplot(x="horas_separadas", hue="finalizados" y="preco", data=dados) - pinta o finalizado com outra cor
   - sns.scatterplot(x="horas_separadas", y="preco", col="finalizados", data=dados) - criando dois graficos
   - - sns.scatterplot(x="horas_separadas", y="preco", hue="finalizados" col="finalizados", data=dados) - separação de cor e coluna
   
- modelando o meus dados
  - x = dados [['horas_esperadas', 'preco']]
  - y = dados['finalizado']
  -  - from sklearn.model_selection import train_test_split
  - from sklearn.svm import LinearSVC
  - from sklearn.metrics import accuracy_score
  - SEED = 20 - numero declaro por o meu resultado fica variando a cada busca
  - treino_x, teste_x, treino_y, teste_y = train_test_split(x, y, random_state = SEED, test_size = 0.25, stratify = y) - aqui eu uso o meu random state, o stratify e falando a minha maquina para ela stratificar de acordo com o y assim eu tenho uma aproximidade nas duas tabelas
  - print("Treinaremos com %d elementos e testaremos com %d elementos" % (len(treino_x), len(teste_x)))
  - modelo = LinearSVC()
  - modelo.fit(train_x, train_y)
  - previsoes = modelo.predict(train_x)
  acuracia = accuracy_score(teste_y, previsoes)
 - print("A acuracia foi %.2f%%" % accuracia)

- Qual foi a previsão do guilherme
  - import numpy as np
  - privisoes_do_guilherme = np.ones(540) - criado 540 numero 1
  - acuracia = accuracy_score(teste_y, previsoes_do_guilherme) * 100
  - print("Aacuracia do guilherme foi %.2f%%" % acuracia"
