# API-herois

## Integrantes: Levi da Costa Bergamascki Matins e Jaime Koji Santana Pereira
## api: https://superheroapi.com/ 
## Filtramos e escolhemos as melhores entidades e classes para a api baseada no tema de herois
<p float = "left"> 

 ## MER
 <img src="https://github.com/levibergamascki/API-herois/blob/main/mer.png" width="600" />

 ## MODELO FÍSICO
 <img src="https://github.com/levibergamascki/API-herois/blob/main/fisico.png" width="600" />

 ## DIAGRAMA DE CLASSES
  <img src="https://github.com/levibergamascki/API-herois/blob/main/classe.png" width="600" />


## Observações para o uso da API
  Devido ao fato de que não criamos um banco de dados online, você terá que alterar algumas informações no arquivo "appsettings.json", no arquivo você deverá trocar um dos valore da ConnectionString. Altere o Server para o nome do servidor que você utilizará em sua máquina (lembre-se que estamos usando SQL Server). Por final, você deverá criar o banco, para tal, apenas abra o console do gerenciador de pacotes nuget e digite: Update-Database.

Observação quanto ao Script:
Já que usamos Entity Framework, não criamos um banco de forma manual, logo o "script" seriam as migrations dentro do projeto, ao usar o comando Update-Database, ele roda as migrations e cria um banco de forma automática, seguindo as classes dentro da API.

## Prints do funionamento:

## INSERT
<img src="https://github.com/levibergamascki/API-herois/blob/main/insert.png" width="600" />

## SELECT
<img src="https://github.com/levibergamascki/API-herois/blob/main/select.png" width="600" />

## SELECT BY ID
<img src="https://github.com/levibergamascki/API-herois/blob/main/SelectById.png" width="600" />

## UPDATE
<img src="https://github.com/levibergamascki/API-herois/blob/main/Update.png" width="600" />
