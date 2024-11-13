# GymTime Citrino

![Versão](https://img.shields.io/badge/versão-MVP-blue) 
![Versão](https://img.shields.io/badge/versão-1.0.0-blue) 
![Última Atualização](https://img.shields.io/github/last-commit/DiegoMaiaSantos/gymtime-citrino-app) 
![Licença](https://img.shields.io/github/license/DiegoMaiaSantos/gymtime-citrino-app) 
![GitHub Stars](https://img.shields.io/github/stars/DiegoMaiaSantos/gymtime-citrino-app?style=social)

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white&color=239120)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white&color=512BD4)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-512BD4?style=flat&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat&logo=microsoft-sql-server&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=flat&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=flat&logo=bootstrap&logoColor=white)
![jQuery](https://img.shields.io/badge/jQuery-0769AD?style=flat&logo=jquery&logoColor=white)
#

## Objetivo do MVP ![Versão](https://img.shields.io/badge/versão-MVP-blue)
Permitir que os moradores possam reservar horários na academia do condomínio, visualizando a disponibilidade diretamente pela web ou pelo celular.

## Funcionalidades para o MVP
- **Cadastro de Moradores**: Área onde o administrador do sistema (ou o síndico) pode cadastrar moradores, com dados básicos como nome, unidade, e-mail e senha.
- **Agendamento de Horário**: Os moradores podem escolher um horário disponível para treinar, com limite de pessoas por horário (ex.: máximo de 5 pessoas por hora).
- **Controle de Acessos**: Cada morador deve ter acesso apenas ao próprio perfil e aos horários da academia.
- **Validação de Horários**: Implementar uma lógica para garantir que o limite de usuários por horário seja respeitado.
- **Consulta de Agendamentos**: Permitir que os moradores visualizem os horários que já agendaram.

## Tecnologias e Ferramentas

### Back-End
- **.NET 8** - Plataforma para desenvolvimento.
- **ASP.NET MVC** - Para controle das páginas e rotas da aplicação.
- **Entity Framework Core** - Para interação com o SQL Server, gerenciando dados de agendamentos, moradores e horários.

### Front-End
- **HTML, CSS e Bootstrap** - Layout e responsividade.
- **jQuery** - Para interações e AJAX, permitindo carregamento dinâmico dos horários.
- **Razor** - Renderização de views e componentes do MVC.

### Banco de Dados
- **SQL Server** - Armazenamento de informações dos moradores, horários e agendamentos.

### Mobile Access
- **Responsive Design com Bootstrap** - Garantir boa experiência em dispositivos móveis.
- **Progressive Web App (PWA)** - Uma possível evolução para permitir que o site seja salvo como app no celular e usado offline.

## Funcionalidades para a Versão 1.0.0 ![Versão](https://img.shields.io/badge/versão-1.0.0-blue)

- **Notificações**: Enviar e-mails de confirmação e lembretes para os moradores sobre os horários agendados.
- **Cancelamento de Agendamentos**: Permitir que os moradores cancelem horários com antecedência.
- **PWA (Progressive Web App)**: Melhorar a experiência em dispositivos móveis, permitindo que o site funcione como um aplicativo.
- **Relatórios**: Criar relatórios para o administrador ver estatísticas de uso, como horários mais frequentes e número de agendamentos por morador.
- **Login Social (futuro)**: Oferecer login com Google ou Facebook para simplificar o processo de autenticação.

## Configuração de Segurança

- **Autenticação e Autorização**: Usar Identity Core ou o sistema de autenticação do ASP.NET para gerenciar a segurança dos usuários.
- **Hashing de Senhas**: Garantir que as senhas sejam hashadas no banco de dados.
- **Controle de Acessos**: Verificar as permissões para que cada morador acesse apenas os próprios agendamentos.

---
