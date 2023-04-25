using xadrez_cli.tabuleiro;

namespace xadrez_cli.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
