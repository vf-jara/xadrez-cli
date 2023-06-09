﻿

namespace xadrez_cli.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //CONSTRUTOR
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //METODOS
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha,coluna];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha,posicao.coluna];
        }

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        public void colocarPeca(Peca p, Posicao posicao)
        {
            if(existePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }

            pecas[posicao.linha, posicao.coluna] = p;
            p.posicao = posicao;
        }

        public bool posicaoValida(Posicao posicao)
        {
            if(posicao.linha<0 || posicao.linha>=linhas || posicao.coluna<0 || posicao.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao posicao)
        {
            if(!posicaoValida(posicao))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }
    }
}
