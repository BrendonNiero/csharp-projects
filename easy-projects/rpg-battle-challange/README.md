# Desafio de batalha em RPG

Em algumas das funções que desempenham jogos, o personagem do jogador batalha contra personagens não controlados por outros jogadores, qque geralmente são monstros ou vilões. Às vezes, uma batalha consiste em cada personagem gerar um valor aleatório jogando dados, e esse valor é subtraído dos pontos de vida do adversário. Quando a vida de um personagem chega a zero, ele perde o jogo.

Neste desafio, reduzimos essa interação à sua essênncia. Um herói e um monstro começam com a mesma pontuação de integridade. Durante a vez do herói, ele gera um valor aleatório que é subtraído a vida do monstro. Se a vida do monstro for maior ue zero, ele toma sua vez e ataca o herói. Enquanto tanto o herói quanto o monstro tiverem a vida maior que zero, a batalha continua.