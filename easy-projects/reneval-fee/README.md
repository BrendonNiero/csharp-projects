# Aprimorar a taxa de renovação de assinaturas
Foi solicitado que você adicionasse um recurso ao software de sua empresa. O recurso destina-se a melhorar a taxa de renovação das assinaturas do software. Sua tarefa é exibir uma menssagem de renovação quando um usuário fizer login no
sistema de software e receber a notificação de que a assinatura está prestes a ser encerrada. Você precisará adicionar um
par de instruções de decisão para adicionar corretamente a lógica de ramificação ao aplicativo para atender aos requisitos.

## Regras de negócios
- Regra 1: Seu código dever exibir apenas uma menssagem. A menssagem dependerá das outras cinco regras.

- Regras 2: Se a assinatura do usuário expirar em dez dias ou menos, será exibida a menssagem:
Your subscription will expire soon. Renew now!

- Regra 3: Se a assinatura do usuário expirar em cinco dias ou menos, será exibida a menssagem:
Your subscription expires in __ days.
Renew now and save 10%!

- Regra 4: Se a assinatura do usuário expirar em um dia, serão exibidas as menssagens:
Your subscription expires within a day!
Renew now and save 20%!

- Regra 5: Se a assinatura do usuário tiver expirado, será exibida a menssagem:
Your subscription has expired.

- Regra 6: Se a assinatura do usuário não expirar em dez dias ou meno, não será exibida nenhuma menssagem.

## Dica
Use um else if para garantir que cada regra de expiração seja considerada.