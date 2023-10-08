
# Plano de Testes de Software

A seguir os cenários de teste que atendem aos requisitos e que foram utilizados na realização dos testes desta aplicação.
Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.

## Cenários de Teste

| Nº Teste | Página | Cenário de teste |
|----------|--------|------------------|
|CT-001| Login | Ao preencher os campos "E-mail" e "Password" com e-mail e senha que já são cadastrados no sistema e clicar em "Login", o usuário deve ser redirecionado para a página "Home" e estar logado no sistema. |
|CT-002| Login | Ao preencher os campos "E-mail" e "Password" com e-mail ou senha que não são cadastrados no sistema e clicar em "Login", o usuário deve visualizar uma mensagem de erro. |
|CT-003| Login | Ao clicar em "Forgot Password?", o usuário deve ser redirecionado para a página de "Recuperar Senha". |
|CT-004| Login | Ao clicar em "Login with Google", se o usuário estiver logado no aparelho com a conta do Google, então ele deve ser redirecionado para a página "Home" e estar logado no sistema. |
|CT-005| Login | Ao clicar em "Login with Google", se o usuário não estiver logado no aparelho com a conta do Google, então deve ser redirecionado para a tela de login do Google. |
|CT-006| Login | Ao clicar em "Create a new account", é esperado que abra a página de Cadastro. |
|CT-007| Recuperar Senha | Ao preencher o campo "E-mail" com e-mail que já é cadastrado no sistema e clicar em "Enviar", é esperado que usuário receba e-mail com a senha. |
|CT-008| Recuperar Senha | Ao clicar em "Retornar para Login", é esperado que usuário seja redirecionado para a tela de Login. |
|CT-009| Cadastro | Ao preencher todos os campos válidos e clicar em "Create new account", o usuário deve receber e-mail de confirmação e ser redirecionado para a página de "Login". |
|CT-010| Cadastro | Ao preencher algum campo incorretamente e clicar em "Create new account", o usuário deve visualizar mensagem de erro referente ao campo inválido. |
|CT-011| Cadastro | Ao clicar em "Already have an accoun? Sign in", é esperado que usuário seja redirecionado para a página de "Login". |
|CT-012| Home | É esperado que seja carregado os ícones das funcionalidades da Plataforma MedOrganizer e o calendário com a agenda do mês atual. |
|CT-013| Home | Ao clicar no ícone "Médicos", é esperado que o usuário seja redirecionado para a página "Médicos". |
|CT-014| Home | Ao clicar no ícone "Clínicas", é esperado que o usuário seja redirecionado para a página "Clínicas". |
|CT-015| Home | Ao clicar no ícone "Medicamentos", é esperado que o usuário seja redirecionado para a página "Medicamentos". |
|CT-016| Home | Ao clicar no ícone "Agendamentos", é esperado que o usuário seja redirecionado para a página "Agendamentos". |
|CT-017| Home | Ao clicar no ícone "Documentos", é esperado que o usuário seja redirecionado para a página "Documentos". |
|CT-018| Home | Ao clicar em algum dia do calendário, é esperado que o usuário seja redirecionado para a página de "Agendamentos" daquele dia. |
|CT-019| Home | Ao clicar no ícone do perfil de usuário, é esperado que o usuário seja redirecionado para a página de "Dados Pessoais". |
|CT-020| Home | Ao clicar em "Sair", é esperado que o usuário seja redirecionado para a página de "Login". |
|CT-021| Médicos | É esperado que seja exibido lista com todos os médicos já cadastrados e opção de cadastrar novo médico. |
|CT-022| Médicos | Ao clicar em "Novo Médico", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o médico seja salvo no sistema e o modal feche. |
|CT-023| Médicos | Ao clicar em "Novo Médico", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. |
|CT-024| Clínicas | É esperado que seja exibido lista com todas as clínicas e laboratórios já cadastrados e opção de cadastrar nova clínica. |
|CT-025| Clínicas | Ao clicar em "Nova Clínica", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", a clínica seja salva no sistema e o modal feche. |
|CT-026| Clínicas | Ao clicar em "Nova Clínica", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. |
|CT-027| Medicamentos | É esperado que seja exibido lista com todos os médicamentos já cadastrados e opção de cadastrar novo medicamento. |
|CT-028| Medicamentos | Ao clicar em "Novo Medicamento", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o medicamento seja salvo no sistema e o modal feche. |
|CT-029| Medicamentos | Ao clicar em "Novo Medicamento", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. |
|CT-030| Agendamentos | É esperado que seja exibido lista com todos os agendamentos já cadastrados com opções de filtros e de cadastrar novo agendamento. |
|CT-031| Agendamentos | Ao clicar em "Novo Agendamento", é esperado que seja exibido um modal, onde ao preencher todos os campos corretamente e clicar em "Salvar", o agendamento seja salvo no sistema e o modal feche. |
|CT-032| Agendamentos | Ao clicar em "Novo Agendamento", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. |
|CT-033| Documentos | É esperado que seja exibido lista com todos os documentos já carregados e opção de carregar novo documento. |
|CT-034| Documentos | Ao clicar em "Novo Arquivo", é esperado que seja exibido um modal, onde ao selecionar o tipo do documento, fazer o upload e clicar em "Salvar", o arquivo seja salvo no sistema e o modal feche. |
|CT-035| Documentos | Ao clicar em "Novo Arquivo", é esperado que seja exibido um modal, onde ao clicar em "Cancelar" ou no ícone "X" o modal feche. |
|CT-036| Dados Pessoais | Ao clicar em "Atualizar Dados Pessoais", alterar algum campo corretamente e clicar em "Salvar", é esperado que o cadastro do usuário seja atualizado no sistema. |
|CT-037| Dados Pessoais | Ao clicar em "Atualizar Dados Pessoais" e depois em "Cancelar", a edição é cancelada. |
