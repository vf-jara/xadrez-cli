using xadrez_cli.tabuleiro;

namespace xadrez_cli.xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T ";
        }
    }
}
