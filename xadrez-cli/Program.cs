using xadrez_cli;
using xadrez_cli.tabuleiro;
using xadrez_cli.xadrez;

Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));

tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 3));
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));


Tela.imprimirTabuleiro(tab);

Console.ReadLine();