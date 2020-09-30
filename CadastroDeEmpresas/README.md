# Plataforma integrada
Exercício feito com único propósito de ingresso no processo de seleção para oportunidade de desenvolvimento na Uppertools Tecnologia da Informação

# Justificativas
O projeto foi realizado com a intenção de seguir o padrão MVC, tentanto utilizar o máximo de recursos conhecidos pelo desenvolvedor (Carlos Felício). A solução possui os métodos DELETE, INSERT, SEARCH funcionais, sempre apresentando uma View responsável por confirmar a ação do usuário, foram implementados protocolos Http e testados utilizando o software Postman, todos funcionais. Entretanto, alguns recursos não foram implementados devido o pouco tempo disponível para desenvolver no espaço de uma semana por motivos pessoais, sendo eles: As propriedades Json que retornavem listas apresentaram erro e não foi possível solucionar a tempo. Validações como O CNPJ informado é valido? Existem informações sobre o CNPJ na receita federal? O web service da receita está disponível? e o método de busca por Nome não foram implementadas por falta de conhecimento técnico.. 

# Arquitetura
Ao pesquisar um CNPJ na WEB API Receitaws, a entrada armazena o cnpj digitado em uma propiedade da model Receitaws, após clicar em buscar, o botão buscar chama o controlador Detais resposável por requisitar os dados do cnpj através do método RequestGET na Model Receitaws, assim que o Json é requisitado ele é desserializado, armazenando os dados do Json em um objeto CompanyModel. Ao acessar a interface Details, o controlador Detais é responsável por enviar os dados para a View através de um ViewBag e manter dados temporários em um TempData que é chamado caso o usuario queira inserir os mesmos dados no banco, o método Register retorna uma página de confirmação do pedido do usuário. Caso o usuário queira buscar uma empresa no Banco de Dados, ao inserir o cnpj e clicar em buscar, o controlador ConsultCompany efetua o método ConsutCompany da model CompanyModel, assim realizando a busca através de comandos tsql e retornando os dados através do controlador e enviado-os para a view em uma ViewBag e mantendo dados temporários em uma TempData até que o controlador Delete seja requisitado. 

# Dificuldades gerais
O enunciado do exercício foi extremamente claro e o tempo passado com certeza suficiente para desenvolver a Web Aplication. Todas as dificuldades enfrentadas são pessoais, sendo o tempo disponível do desenvolvedor o maior inimigo e algumas áreas que precisam ser mais estudadas, como frontend com asp.net e controladores.

# Conclusão
Foi o maior desafio que já tive em busca de um estágio e fico feliz por isso. Aprendi muito e hoje tenho em mente como é trabalhar na área de desenvolvimento de forma mais clara. Obrigado Uppertools pelo desafio e oportunidade! Foi incrível!
