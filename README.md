# AM 2019 - White Cheese Technology

## Portal

Para acesso no site basta acessar [http://white-cheese.s3-website-sa-east-1.amazonaws.com/](http://white-cheese.s3-website-sa-east-1.amazonaws.com/). (Detalhes: A Api e o Banco MySql devem estar no ar localmente)

Para conferência do código, os arquivos estão em **/portal**

Caso a porta do localhost seja trocada, ou o endpoint mude, basta alterar o arquivo **Src > assets > config.json**


## Api e Scrapping

**Utilizar a versão 12.3.0 do nodeJs e última versão estável do npm**

Para o banco de dados é necessário alterar login e senha no arquivo libs> conn.js

Caso não consiga conectar no banco, deve rodar o seguinte código para mudar o tipo de autenticação do banco de dados

    ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'password'

  
Os arquivos encontram-se em **/api**

  

## Banco de Dados

  
Basta rodar o arquivo encontrado em **/bd** para preparar o ambiente


## Fluxo

Detalhamento do fluxo de pesquisa de Pessoas na raiz do repositório


## Aplicativo**

Desenvolvido em Xamarin.forms. Também deve estar com banco e api conectados para seu funcionamento. Encontra-se em **/app**