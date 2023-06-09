﻿
namespace xadrez_cli.tabuleiro
{
    class Peca
    {   //Atributos
        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //Construtor
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
