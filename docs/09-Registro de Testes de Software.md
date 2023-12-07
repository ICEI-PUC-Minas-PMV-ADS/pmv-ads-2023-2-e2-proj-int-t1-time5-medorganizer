# Registro de Testes de Software

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado no <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>.

## Avaliação

Conforme testes realizados para verificação dos cenários de teste de software definidos antecipadamente, obtivemos os seguintes resultados:

### Login
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-001| Ao preencher os campos "E-mail" e "Senha" com e-mail e senha que já são cadastrados no sistema e clicar em "Login", o usuário deve ser redirecionado para a página "Home" e estar logado no sistema. | Ao logar redireciona para a página Home |
|CT-002| Ao preencher os campos "E-mail" e "Senha" com e-mail ou senha que não são cadastrados no sistema e clicar em "Login", o usuário deve visualizar uma mensagem de erro. | É exibido mensagens de erro para campos inválidos |
|CT-003| Ao clicar em "Esqueceu sua senha?", o usuário deve ser redirecionado para a página de "Recuperar Senha". | É redirecionado para página de Recuperar Senha |
|CT-004| Ao clicar em "Login with Google", se o usuário estiver logado no aparelho com a conta do Google, então ele deve ser redirecionado para a página "Home" e estar logado no sistema. | Funcionalidade não disponível |
|CT-005| Ao clicar em "Login with Google", se o usuário não estiver logado no aparelho com a conta do Google, então deve ser redirecionado para a tela de login do Google. | Funcionalidade não disponível |
|CT-006| Ao clicar em "Registre-se como um novo usuário", é esperado que abra a página de Cadastro. | Está redirecionando para página de Cadastro |

### Recuperar Senha
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-007| Ao preencher o campo "E-mail" com e-mail que já é cadastrado no sistema e clicar em "Enviar", é esperado que usuário receba e-mail com a senha. | Funcionalidade não atendida |
|CT-008| Ao clicar em "Retornar para Login", é esperado que usuário seja redirecionado para a tela de Login. | Funcionalidade não atendida |

### Cadastro
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-009| Ao preencher todos os campos válidos e clicar em "Registro", o usuário deve receber e-mail de confirmação e ser redirecionado para a página de "Login". | É exibido mensagem de confirmação na tela mas não é enviado e-mail de confirmação |
|CT-010| Ao preencher algum campo incorretamente e clicar em "Registro", o usuário deve visualizar mensagem de erro referente ao campo inválido. | É exibido mensagens de erro para campos inválidos |
|CT-011| Ao clicar em "Registro", é esperado que usuário seja redirecionado para a página de "Login". | Não está redirecionando para página de Login |

### Home
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-012| É esperado que seja carregado os ícones das funcionalidades da Plataforma MedOrganizer e o calendário com a agenda do mês atual. | Carrega os ícnoes das funcionalidades e a agenda, mas não a do mês atual | 
|CT-013| Ao clicar no ícone "Médicos", é esperado que o usuário seja redirecionado para a página "Médicos". | É redirecionado para página de Médicos | 
|CT-014| Ao clicar no ícone "Clínicas", é esperado que o usuário seja redirecionado para a página "Clínicas". | É redirecionado para página de Clínicas | 
|CT-015| Ao clicar no ícone "Medicamentos", é esperado que o usuário seja redirecionado para a página "Medicamentos". | É redirecionado para página de Medicamentos | 
|CT-016| Ao clicar no ícone "Agendamentos", é esperado que o usuário seja redirecionado para a página "Agendamentos". | É redirecionado para página de Agendamentos | 
|CT-017| Ao clicar no ícone "Documentos", é esperado que o usuário seja redirecionado para a página "Documentos". | Foi alterado para Prescrições e é redirecionado para página de Prescrições | 
|CT-018| Ao clicar em algum dia do calendário, é esperado que o usuário seja redirecionado para a página de "Agendamentos" daquele dia. | Não atendido, é exibido listagem geral de agendamentos | 
|CT-019| Ao clicar no ícone do perfil de usuário, é esperado que o usuário seja redirecionado para a página de "Dados Pessoais". | Funcionalidade não atendida | 
|CT-020| Ao clicar em "Logout", é esperado que o usuário seja redirecionado para a página de "Login". | É deslogado do sistema e redirecionado para página de Login | 

### Médicos
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-021| É esperado que seja exibido lista com todos os médicos já cadastrados e opção de cadastrar novo médico. | É exibido lista de Médicos já cadastrados e as opções de editar, excluir, ver detalhes ou cadastrar novo médico | 
|CT-022| Ao clicar em "Novo Médico", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o médico seja salvo no sistema e o modal feche. | Não abre modal, é redirecionado para outra página onde ao cadastrar novo médico foi salvo e exibido na lista | 
|CT-023| Ao clicar em "Novo Médico", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. | Não abre modal, é redirecionado para outra página onde ao clicar em Voltar, é redirecinado para página inicial de Médicos | 

### Clínicas
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-024| É esperado que seja exibido lista com todas as clínicas e laboratórios já cadastrados e opção de cadastrar nova clínica. | É exibido lista de Clínicas já cadastradas e as opções de editar, excluir, ver detalhes ou cadastrar nova clínica |
|CT-025| Ao clicar em "Nova Clínica", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", a clínica seja salva no sistema e o modal feche. | Não abre modal, é redirecionado para outra página onde ao cadastrar nova clínica foi salva e exibida na lista |
|CT-026| Ao clicar em "Nova Clínica", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. | Não abre modal, é redirecionado para outra página onde ao clicar em Voltar, é redirecinado para página inicial de Clínicas |

### Medicamentos
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-027| É esperado que seja exibido lista com todos os medicamentos já cadastrados e opção de cadastrar novo medicamento. | É exibido lista de Medicamentos já cadastrados e as opções de editar, excluir, ver detalhes ou cadastrar novo médico |
|CT-028| Ao clicar em "Novo Medicamento", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o medicamento seja salvo no sistema e o modal feche. | Não abre modal, é redirecionado para outra página onde ao cadastrar novo medicamento foi salvo e exibido na lista |
|CT-029| Ao clicar em "Novo Medicamento", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. | Não abre modal, é redirecionado para outra página onde ao clicar em Voltar, é redirecinado para página inicial de Medicamentos |

### Agendamentos
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-030| É esperado que seja exibido lista com todos os agendamentos já cadastrados com opções de filtros e de cadastrar novo agendamento. | Agendamentos | 
|CT-031| Ao clicar em "Novo Agendamento", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o agendamento seja salvo no sistema e o modal feche. | Agendamentos | 
|CT-032| Ao clicar em "Novo Agendamento", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. | Agendamentos |

### Prescrições (Documentos)
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-033| É esperado que seja exibido lista com todos os documentos já carregados e opção de carregar novo documento. | Documentos |
|CT-034| Ao clicar em "Novo Arquivo", é esperado que seja exibido um modal, onde ao selecionar o tipo do documento, fazer o upload e clicar em "Salvar", o arquivo seja salvo no sistema e o modal feche. | Documentos |
|CT-035| Ao clicar em "Novo Arquivo", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. | Documentos |
  
### Dados Pessoais
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-036| Ao clicar em "Atualizar Dados Pessoais", alterar algum campo corretamente e clicar em "Salvar", é esperado que o cadastro do usuário seja atualizado no sistema. | Dados Pessoais |
|CT-037| Ao clicar em "Atualizar Dados Pessoais" e depois em "Cancelar", a edição é cancelada. | Dados Pessoais |
