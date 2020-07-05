# Projeto de API para cálculo de Juros Composto

Esta API foi criada no modelo de microserviço com comunicação entre a CalculaJurosAPI (API 2) que internamente chama uma outra API chamada RetornaTaxaAPI (API 1).

A API 2 faz uma comunicação Http via get para obter a taxa de juros que será aplicada no cálculo de juros composto.

### Os endpoints

Na API 1 (RetornaTaxaAPI) está disponível apenas um endpoint:

- /TaxaJuros

Na API 2 (CalculaJurosAPI) temos dois endpoints:

- /CalculaJuros: recebe dois parâmetros e pode ser acessado via query string conforme exemplo - /calculajuros?valorinicial=100&meses=5

- /ShowMeTheCode: não recebe nenhum parâmetro e retorna uma string com a Url do projeto.

### Como "subir" os serviços

Devido a comunicação entre a chamada da API 2 com a API 1, esta última precisa estar disponível para o correto funcionamento do serviço de cálculo de juros composto. Para tornar a tarefa de configuração simples da Url do microserviço da API 1 dentro da API 2, dentro desta última no arquivo **appsettings.json** existe uma propriedade/atributo chamada "ApiTaxaJuros" em que deverá ser feita a configuração da URL que aponta para a API que retornar a taxa de juros.

### Swagger

Em ambas APIs foi implementado o Swagger que pode ser acessado pela rota /swagger.

### Docker 

Os dois projetos podem ser executado via docker. Para que isso seja possível você deve:

**Para o projeto (RetornaTaxaAPI):** ir para pasta do projeto /RetornaTaxaAPI e executar os comandos:

- `docker build --pull -t retornataxaapi .`
- `docker run --rm -it -p 3020:3020 retornataxaapi`

Internamente está sendo exposta a porta 3020.

**Para o projeto (CalculaJurosAPI):** ir para pasta do projeto /CalculaJurosAPI e executar os comandos:

**IMPORTANTE:** antes de executar o build deste container você deve se certificar de configurar o arquivo **appsettings.json** deste projeto (CalculaJurosAPI) para apontar corretamente para o IP interno do container da API 1.

Para saber o IP do container da API 1 basta executar o comando:

`docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' <ID_CONTAINER_API_1>`

Para descobrir o ID do container da API 1, basta executar o comando (você irá encontrar o container da image `retornataxaapi` rodando):

`docker ps`

Após fazer a configuração para criar a image e subir o container da API 2, basta executar os seguintes comandos:

- `docker build --pull -t calculajuros .`
- `docker run --rm -it -p 3000:3000 calculajuros`

Internamente está sendo exposta a porta 3000.

### Teste Unitários

Criar o teste (ver falhar) - desenvolver - rodar o teste (sucesso) - refatorar e go! O projeto se baseia nesse aspecto, portanto todos os testes estão de acordo com o esperado. Os teste unirário foram criados usando o MSTest.

### Teste de Integração com Postman

O teste de integração está sendo realizado com a utilização do recurso de test Postman ("Runner") mais a linguagem JavaScript. 

![Screenshot da tela de testes do Postman](https://raw.githubusercontent.com/fabioalmeida100/calcula-juros/master/Screenshot/Screenshoot_result_test_sample.jpg?token=ACMSTUKQGL5OFEFDDJWRBPC7AH3AU)

Na pasta /TesteIntegracao você irá encontrar as ***collections*** dos testes e um ***Environment*** chamado **Local** com a URL configurada para as portas 3020 (API 1) e 3000 (API 2).

