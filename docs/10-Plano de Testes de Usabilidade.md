# Plano de Testes

## Plano de Testes de Software

A seguir os cenários de teste que atendem aos requisitos e que foram utilizados na realização dos testes desta aplicação.
Enumere quais cenários de testes foram selecionados para teste. Neste tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo de usuários que foi escolhido para participar do teste e as ferramentas utilizadas.

### Cenários de Teste de Software

| Nº Teste | Página | Cenário de teste |
|----------|--------|------------------|
|CTS-001| Login | Ao preencher os campos "E-mail" e "Password" com e-mail e senha que já são cadastrados no sistema e clicar em "Login", o usuário deve ser redirecionado para a página "Home" e estar logado no sistema. |
|CTS-002| Login | Ao preencher os campos "E-mail" e "Password" com e-mail ou senha que não são cadastrados no sistema e clicar em "Login", o usuário deve visualizar uma mensagem de erro. |
|CTS-003| Login | Ao clicar em "Forgot Password?", o usuário deve ser redirecionado para a página de "Esqueci Senha". |
|CTS-004| Login | Ao clicar em "Login with Google", se o usuário estiver logado no aparelho com a conta do Google, então ele deve ser redirecionado para a página "Home" e estar logado no sistema. |
|CTS-005| Login | Ao clicar em "Login with Google", se o usuário não estiver logado no aparelho com a conta do Google, então deve ser redirecionado para a tela de login do Google. |
|CTS-006| Login | Ao clicar em "Cadastre", é esperado que abra a página de Cadastro. |
|CTS-007| Esqueci Senha | Ao preencher o campo "E-mail" com e-mail que já é cadastrado no sistema e clicar em "Enviar", é esperado que usuário receba e-mail com a senha. |
|CTS-008| Cadastro | Ao preencher todos os campos válidos e clicar em "Create new account", o usuário deve receber e-mail de confirmação e ser redirecionado para a página de "Login". |
|CTS-009| Cadastro | Ao preencher algum campo incorretamente e clicar em "Create new account", o usuário deve visualizar mensagem de erro referente ao campo inválido. |
|CTS-010| Cadastro | Ao clicar em "Already have an accoun? Sign in", é esperado que usuário seja redirecionado para a página de "Login". |
|CTS-011| Home | É esperado que seja carregado os ícones das funcionalidades da Plataforma MedOrganizer. |
|CTS-012| Home | Ao clicar no ícone . |

## Plano de Testes de Usabilidade

A seguir o planejamento de realização de testes com usuários definindo as operações que os usuários devem realizar nesta aplicação.

### Cenários de Teste de Usabilidade

| Nº Teste | RF-00n | Tarefa do Usuário | Usuário | Taxa de Usabilidade| 
|----------|--------|-------------------|---------|--------------------|
| CTU-001 | RF-001 | Encontre opções para logar, recuperar senha ou se cadastrar na plataforma. | 
| CTU-002 | RF-001 | Preencha os campos corretamente e realize o login na plataforma. | 
| CTU-003 | RF-002 | Preencha os campos corretamente e realize o cadastro na plataforma. | 
| CTU-004 | RF-003 | Verifique recebimento de e-mail com nova senha. | 
| CTU-005 | RF-004 | Encontre informações sobre... |
