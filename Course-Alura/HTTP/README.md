# HTTPS

No certificado, vem a chave pública para o cliente utilizar, certo? E o servidor continua na posse da chave privada, ok? Isso é seguro, mas lento e por isso o cliente gera uma chave simétrica ao vivo. Uma chave só para ele e o servidor com o qual está se comunicando naquele momento! Essa chave exclusiva (e simétrica) é então enviada para o servidor utilizando a criptografia assimétrica (chave privada e pública) e então é utilizada para o restante da comunicação.

Então, HTTPS começa com criptografia assimétrica para depois mudar para criptografia simétrica. Essa chave simétrica será gerada no início da comunicação e será reaproveitada nas requisições seguintes. Bem-vindo ao mundo fantástico do HTTPS :)

# Servidor DNS

Domani Name System resolve para me o nome de uma dominio e devolve um endereço IP 

# Definição de Endereço IP

### HTTPS://www.alura.com.br:443/course/introducao-HTML-CSS

- HTTPS: protocolo
- www.alura.com.br: domínio
- com: site comecial ou governamental
- br: especifico para um determinado pais 
- 443: porta não obrigatorio informar
- course/introducao-HTML-CSS: area especifca de um evento

# URL, URI e URN

### URI
As URIs são o padrão para identificação de documentos com uma curta sequência de números, letras e símbolos. O termo significa no Inglês Uniform Resource Identifier (URI) – Identificador de Recurso Uniforme.

### URL
URLs também seguem uma nomenclatura similar. Significa Uniform Resource Locator – Localizador de Recurso Uniforme. Nesses endereços contém informações sobre como buscar um recurso em sua localização.

Quando falamos de recursos a serem buscados podem ser tanto websites completos (igual esse que você está acessando agora) quanto outros tipos de dados que são transmitidos via web em outros formatos e por meio de outros protocolos que não HTTP ou HTTPS.

Exemplo:

- http://website.com/pagina.html
- ftp://website.com.br/download.zip
- mailto:contato@website.com.br
- file:///home/usuario/arquivo.txt
- tel:+5511123456789

### URN
URN então, seguindo o mesmo padrão dos dois anteriores, significa Uniform Resource Name – Nome de Recurso Uniforme. Ele identifica um recurso na web através de um nome único e persistente, mas não necessariamente ele informa onde o localizar na internet. Normalmente começa com o prefixo urn:.

Por exemplo:

- urn:isbn:042424553 para identificar um livro através de seu número ISBN
- urn:uuid:6e8bc430-9c3a-11d9-9669-0800200c9a66 como un identificador global único
- urn:publishing:book como um XML que identifica um documento como um tipo de livro
- URNs podem identificar ideias e conceitos. Eles não estão restritos a documentos, mas quando eles representam documentos podem ser convertidos a URLs por um “resolver”. A partir daí o documento pode ser baixado através de uma URL.
