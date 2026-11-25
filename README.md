# 🎧 SupportDesk AI

### Plataforma inteligente de gerenciamento de chamados e suporte técnico

O **SupportDesk AI** é uma aplicação web desenvolvida para centralizar e otimizar o atendimento de suporte técnico em empresas.

A plataforma permite gerenciar chamados, usuários, equipes, prioridades, prazos de atendimento e histórico de solicitações. Além disso, utiliza Inteligência Artificial para auxiliar na classificação de problemas e sugerir possíveis soluções.

O projeto tem como objetivo aplicar tecnologias modernas do ecossistema .NET e desenvolvimento Full Stack, seguindo boas práticas de arquitetura, segurança e organização de código.

---

## 🎯 Objetivos do projeto

- Desenvolver uma aplicação Full Stack utilizando C# e React.
- Aprofundar conhecimentos em orientação a objetos e ASP.NET Core.
- Trabalhar com APIs REST e integração com banco de dados.
- Implementar autenticação e autorização.
- Aplicar arquitetura em camadas e princípios SOLID.
- Desenvolver testes automatizados.
- Integrar recursos de Inteligência Artificial.
- Aprender Docker, CI/CD e publicação de aplicações.

## 🚀 Funcionalidades

### Gestão de chamados

- [ ] Abertura de chamados.
- [ ] Edição e acompanhamento de solicitações.
- [ ] Atribuição de chamados aos técnicos.
- [ ] Controle de status e prioridades.
- [ ] Histórico de alterações.
- [ ] Comentários públicos e internos.
- [ ] Anexos de arquivos.

### Gestão de usuários

- [ ] Cadastro e gerenciamento de usuários.
- [ ] Autenticação e logout.
- [ ] Controle de permissões.
- [ ] Perfis de administrador, técnico e solicitante.
- [ ] Gerenciamento de equipes.

### Gestão de atendimento

- [ ] Categorias de chamados.
- [ ] Controle de SLA.
- [ ] Notificações.
- [ ] Dashboard gerencial.
- [ ] Relatórios de atendimento.

### Inteligência Artificial

- [ ] Classificação automática de chamados.
- [ ] Sugestão de prioridades.
- [ ] Resumo de solicitações.
- [ ] Recomendações de possíveis soluções.
- [ ] Assistente para técnicos.

## 🛠️ Tecnologias

### Backend

- C#
- .NET 10 LTS
- ASP.NET Core Web API
- Entity Framework Core
- SignalR

### Frontend

- React
- TypeScript
- Tailwind CSS

### Banco de dados

- PostgreSQL

### Ferramentas e qualidade

- Visual Studio 2026
- Git e GitHub
- Docker
- Postman
- Swagger / OpenAPI
- xUnit
- GitHub Actions

## 🏗️ Arquitetura

O projeto utilizará uma arquitetura em camadas, com separação de responsabilidades.

```text
SupportDesk/
│
├── backend/
│   ├── SupportDesk.API/
│   ├── SupportDesk.Domain/
│   ├── SupportDesk.Application/
│   ├── SupportDesk.Infrastructure/
│   └── SupportDesk.Tests/
│
├── frontend/
│   └── supportdesk-web/
│
├── docs/
│   ├── 01-visao-geral.md
│   ├── 02-requisitos.md
│   ├── 03-regras-de-negocio.md
│   ├── 04-modelagem-banco.md
│   └── 05-arquitetura.md
│
├── docker-compose.yml
├── .gitignore
└── README.md
```

### Responsabilidades das camadas

| Camada         | Responsabilidade                               |
| -------------- | ---------------------------------------------- |
| API            | Receber requisições e disponibilizar endpoints |
| Domain         | Entidades e regras fundamentais de negócio     |
| Application    | Casos de uso e serviços da aplicação           |
| Infrastructure | Banco de dados e integrações externas          |
| Tests          | Testes automatizados                           |

## 🧠 Inteligência Artificial

A IA será utilizada como ferramenta de apoio ao atendimento.

Ela poderá analisar as descrições dos chamados, identificar categorias prováveis, sugerir prioridades e recomendar soluções.

Todas as sugestões deverão ser avaliadas por um usuário autorizado antes de serem aplicadas.

## 📅 Roadmap de desenvolvimento

- [x] Definição da ideia e tecnologias.
- [ ] Etapa 1 — Planejamento e modelagem.
- [ ] Etapa 2 — Estruturação do Backend.
- [ ] Etapa 3 — Autenticação e usuários.
- [ ] Etapa 4 — Gestão de chamados.
- [ ] Etapa 5 — Equipes e atribuições.
- [ ] Etapa 6 — Comentários, anexos e histórico.
- [ ] Etapa 7 — SLA e notificações.
- [ ] Etapa 8 — Desenvolvimento do Frontend.
- [ ] Etapa 9 — Dashboard e relatórios.
- [ ] Etapa 10 — Integração com IA.
- [ ] Etapa 11 — Comunicação em tempo real com SignalR.
- [ ] Etapa 12 — Testes automatizados.
- [ ] Etapa 13 — Docker e CI/CD.
- [ ] Etapa 14 — Publicação e documentação final.

## 🔐 Segurança

O projeto prevê:

- Armazenamento seguro de senhas.
- Autenticação e autorização.
- Proteção dos endpoints.
- Validação de dados.
- Controle de acesso aos chamados.
- Isolamento de dados por organização.
- Proteção de informações sensíveis.

## 💻 Ambiente de desenvolvimento

O desenvolvimento será realizado utilizando:

- Visual Studio 2026.
- .NET 10 SDK.
- PostgreSQL.
- Node.js LTS.
- Git e GitHub.

## 📚 Objetivo educacional

Este projeto está sendo desenvolvido como uma iniciativa prática de aprofundamento em programação C#, desenvolvimento Full Stack e engenharia de software.

A proposta é construir uma aplicação realista, evoluindo gradualmente desde o planejamento e modelagem até os testes e publicação.

## 📌 Status

**Em desenvolvimento — Etapa 1: Planejamento e modelagem.**

---

Desenvolvido como projeto de estudo e portfólio profissional.
