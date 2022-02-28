# SistemaBarbearia

Sistema Barbearia é um projeto pessoal que faz o gerenciamento de clientes e agendamentos. Sua construção foi feita no intuito de aprender melhor as relações entre o C# e banco de dados, o banco de dados usado nesse projeto é o SqlServer.

## Segue um resumo de como foi a construção do projeto

Primeiramente ele foi pensado e contruído usando o modelo "padrão" de acesso a dados do C#/.NET, por meio da lib Microsoft.Data.SqlClient, foi uma tarefa complexa de ser feita pois após uma query era nescessário fazer a relação manual entre as tabelas e os objetos, isso aumentava muito a chances de cometer erros, tanto de conversões de tipos, como a atriubuição de valores em si. Porém, não me arrempendo nem um pouco de ter ficado horas e horas nessa implementação, já que posteriormente quando implementei o Dapper no sistema, já conseguia enxergar as relações entre o C# e SqlServer bem melhor.

O Dapper me surpreendeu bastante, já que me tirou 50% do trabalho de fazer as relações entre o banco e o C#, porém tive que fazer um remodelo no banco para tudo funcionar direito. Após a implementação do Dapper, comecei a aprender a trabalhar com o Entity Framework Core, facilitou ainda mais o sistema, já que nem as querys precisava digitar kk(na maioria dos casos, já que em algumas querys um pouco  mais complexas preferi digitar manualmente). Desenvolvi também uma melhor compreensão do Git e Github e suas funcionalidades. Por fim, esse projeto foi meu treino por muito tempo nas relações entre C# e SqlServer, quem sabe mais para frente eu dê continuidade para ele.
Um resumo dele funcionando: https://www.linkedin.com/feed/update/urn:li:activity:6895829017304666112/
