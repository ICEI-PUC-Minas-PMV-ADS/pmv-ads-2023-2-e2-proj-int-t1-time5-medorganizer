# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas, histórias de usuários, requisitos e restrições.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas abaixo:

1. Carlos Eduardo tem 50 anos, é engenheiro, casado e pai de três filhos. Deseja manter a saúde para aproveitar a vida com a família, mas falta tempo para cuidar da saúde. Está em busca de uma ferramenta que o ajude a se planejar melhor e então se dedicar para o cuidado da sua saúde.

2. Dona Helena tem 80 anos, é posentada, mora sozinha e possui uma cuidadora. Gostaria de ter independência e compartilhar informações com os filhos, mas tem dificuldade em usar novas tecnologias. A sua cuidadora poderia auxiliá-la com agendamentos e lembretes de consultas e medicações.

3. Lucas Moreira tem 21 anos, trabalha como programador júnior e também estuda. Deseja crescimento profissional e manter a forma física, mas tem dificuldade de ncontrar suplementos adequados. Busca locais confiáveis para compra de suplementação adequada.

4. Gabriela Souza tem 35 anos, é nutricionista e tem um filho. Pensa em promover uma vida saudável para sua família, mas tem dificuldade de equilibrar trabalho e vida pessoal. Gostaria de uma agenda funcional para organizar sua rotinna de alimentação, suplementação e treinos.

5. Roberto Alves tem 28 anos e atua como profissional de marketing em uma startup. Deseja crescimento profissional, mas com equilíbrio entre trabalho e vida pessoal, poém o estresse no trabalho tem o afetado bastante. Está em busca de ferramentas que o ajude a relaxar, com lembretes de pausa no trabalho, dicas de exercícios de respiração e meditação.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

Cojm base nas histórias de usuários, foi definido os requisitos funcionais e não funcionais que detalham o escopo do projeto e estão descritos nas tabelas a seguir.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve fornecer uma tela de login | ALTA | 
|RF-002| O sistema deve permitir o cadastro de novos usuários | ALTA |
|RF-003| O sistema deve possibilitar recuperação de senha | ALTA |
|RF-004| O sistema deve permitir que os usuários gerenciem seus perfis e informações médicas | ALTA |
|RF-005| O sistema deve permitir o cadastro e monitoramento de medicações | ALTA |
|RF-006| O sistema deve integrar um calendário para lembretes de medicamentos | ALTA |
|RF-007| O sistema deve armazenar prescrições médicas | ALTA |
|RF-008| O sistema deve permitir o armazenamento de exames médicos realizados | MÉDIA |
|RF-009| O sistema deve fornecer informações sobre farmácias parceiras | MÉDIA |
|RF-010| O sistema deve enviar automaticamente receitas médicas para farmácias parceiras | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser publicado em um ambiente acessível na Internet | MÉDIA | 
|RNF-002| A solução deve ser multiplataforma e responsiva | BAIXA | 
|RNF-003| O sistema deve ter uma interface amigável e intuitiva | MÉDIA | 
|RNF-004| Compatibilidade com os principais navegadores | BAIXA | 
|RNF-005| Armazenamento seguro de informações médicas | BAIXA | 
|RNF-006| Construção do sistema utilizando JavaScript, CSS, e HTML5 | BAIXA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Sem subcontratação do desenvolvimento |
|03| O sistema não pode armazenar dados sensíveis sem criptografia |
|04| A solução deve ser compatível com as regulamentações de privacidade de dados |
|05| A equipe deve realizar testes periódicos de segurança |
|06| O sistema deve ser gratuito para os usuários |
|07| Possibilidade de parcerias com farmácias para integração |
|08| Publicidade e promoções devem ser limitadas e não intrusivas |
|09| A equipe deve realizar reuniões semanais de status |
|10| Todos os membros da equipe devem participar ativamente das decisões |
