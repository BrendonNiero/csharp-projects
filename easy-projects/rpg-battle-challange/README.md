# Desafio de batalha em RPG

Em algumas das funções que desempenham jogos, o personagem do jogador batalha contra personagens não controlados por outros jogadores, qque geralmente são monstros ou vilões. Às vezes, uma batalha consiste em cada personagem gerar um valor aleatório jogando dados, e esse valor é subtraído dos pontos de vida do adversário. Quando a vida de um personagem chega a zero, ele perde o jogo.

Neste desafio, reduzimos essa interação à sua essênncia. Um herói e um monstro começam com a mesma pontuação de integridade. Durante a vez do herói, ele gera um valor aleatório que é subtraído a vida do monstro. Se a vida do monstro for maior ue zero, ele toma sua vez e ataca o herói. Enquanto tanto o herói quanto o monstro tiverem a vida maior que zero, a batalha continua.

## Veja as regras para o jogo que você precisa implementar em seu projeto
- Você deve usar a instrução do-while ou a instrução while como um loop do jogo externo.
- O herói e o monstro começam com 10 pontos de vida.
- Todos os ataues têm um valor entre 1 e 10.
- O herói ataca primeiro.
- Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
- Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
- Imprima quem foi o vencedor.

### Não importa como você fará isso; o código deverá produzir uma saída semelhante:
``` bash
    Monster was damaged and lost 1 health and now has 9 health.
    Hero was damaged and lost 1 health and now has 9 health.
    Monster was damaged and lost 7 health and now has 2 health.
    Hero was damaged and lost 6 health and now has 3 health.
    Monster was damaged and lost 9 health and now has -7 health.
    Hero wins!
```