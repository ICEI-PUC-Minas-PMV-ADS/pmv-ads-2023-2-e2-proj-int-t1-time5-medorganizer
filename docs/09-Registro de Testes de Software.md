# Registro de Testes de Software

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado no <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>.

## Avaliação

Conforme testes realizados para verificação dos cenários de teste de software definidos antecipadamente, obtivemos os seguintes resultados:

### Login
| Nº Teste | Cenário de teste | Registro de teste |
|----------|--------|------------------|
|CT-001| Ao preencher os campos "E-mail" e "Senha" com e-mail e senha que já são cadastrados no sistema e clicar em "Login", o usuário deve ser redirecionado para a página "Home" e estar logado no sistema. | Correto |
|CT-002| Ao preencher os campos "E-mail" e "Senha" com e-mail ou senha que não são cadastrados no sistema e clicar em "Login", o usuário deve visualizar uma mensagem de erro. | É exibido mensagens de erro para campos inválidos |
|CT-003| Ao clicar em "Esqueceu sua senha?", o usuário deve ser redirecionado para a página de "Recuperar Senha". | Está redirecionando para página de Recuperar Senha |
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

### Medicamentos
- Pontos fortes: Todas as opções de cadastrar, editar, listar, visualizar detalhes, deletar e validações de campos estão funcionando.
- Pontos a melhorar: Título da página de listagem está "Index" e deveria ser "Medicamentos", e mensagens de erro para os campos "Fabricante" e "Descrição" deveria ser em português.
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/d01c1465-dac4-4f8c-8190-c43f6098c08e)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/1241b280-4f01-47a1-8d76-76b12e501efc)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/7a995963-0e35-4ed9-987b-6912f03a0834)

### Clínicas
- Pontos fortes: Todas as opções de cadastrar, editar, listar, visualizar detalhes, deletar e validações de campos estão funcionando, além de título da página e mensagens de erro estarem legíveis e padronizadas.
- Pontos a melhorar: Validação para formato do campo "Email".
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/d26a3e43-7fe1-457a-8527-3baecb19d4c7)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/5d4fc27d-e33d-4f88-a360-09fddaaf6e50)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/030ef4a8-b88f-4388-8d99-6846adc993d3)

### Usuários
- Pontos fortes: Todas as opções de cadastrar, editar, listar, visualizar detalhes, deletar e validações de campos estão funcionando, além de título da página e mensagens de erro estarem legíveis e padronizadas.
- Pontos a melhorar: O campo "Senha" poderia ser exibido com dados mascarados na listagem.
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/1dc86c3d-424f-4309-ba2b-4c2192507b6d)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/ce699f87-5a09-4391-8609-9b4a832bb564)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/698f5638-80ae-496c-a0bc-3e790079efb3)

### Médicos
- Pontos fortes: Todas as opções de cadastrar, editar, listar, visualizar detalhes, deletar e validações de campos estão funcionando, além de ter validação para formato de email.
- Pontos a melhorar: Título da página de listagem está "Index" e deveria ser "Médicos", título da página de detalhes está "Medicamento" e deveria ser "Médico", e mensagens de erro para os campos "Valor da Consulta" e "Anotações" deveria ser em português.
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/5fad8201-de47-4712-a8a7-78a137e57f93)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/72c04398-9678-4db7-8579-c15820166bd3)
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time5-medorganizer/assets/99828297/e88e29a2-cd2a-4ff9-a200-c00553aa4cce)

### Register
- Ainda não foi implementado.
  
### Login
- Ainda não foi implementado.
