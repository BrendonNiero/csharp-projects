# Defasio da lógica de decisão
Neste desafio, vamos implementar uma lógica com base em uma série de regras de negócios.
As regras de negócios especificam o acesso que será concedido aos usuários com base nas respectivas permissões baseadas em função e no nível de carreira.
Os branches de código exibirão uma mensagem diferente para cada usuário, de acordo com as respectivas permissões e o nível.

### Código inicial:
```csharp
string permission = "Admin|Manager";
int level = 55;
```

## Veja as seguintes regras de negócios que a solução dedve atender:

- Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:
```bash
Welcome, Super Admin user.
```

- Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
```bash
Welcome, Admin user.
```

- Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
```bash
Contact an Admin for access.
```

- Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
```bash
You do not have sufficient privileges.
```

- Se o usuário não for um administrador nem um gerente, exiba a mensagem:
```bash
You do not have sufficient privileges.
```