using tabuleiro;

namespace xadrez
{
    internal class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.definirVAlores(posicao.linha, posicao.coluna - 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha, pos.coluna - 1);
            }
            //direita
            pos.definirVAlores(posicao.linha, posicao.coluna + 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha, pos.coluna + 1);
            }
            //acima
            pos.definirVAlores(posicao.linha - 1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha - 1, pos.coluna);
            }
            //abaixo
            pos.definirVAlores(posicao.linha + 1, posicao.coluna);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha + 1, pos.coluna);
            }
            //NO
            pos.definirVAlores(posicao.linha - 1, posicao.coluna - 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha - 1, pos.coluna - 1);
            }
            //NE
            pos.definirVAlores(posicao.linha - 1, posicao.coluna + 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha - 1, pos.coluna + 1);
            }
            //SE
            pos.definirVAlores(posicao.linha + 1, posicao.coluna + 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha + 1, pos.coluna + 1);
            }
            //SO
            pos.definirVAlores(posicao.linha + 1, posicao.coluna - 1);
            while(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirVAlores(pos.linha + 1, pos.coluna - 1);
            }
            return mat;
        }
    }
}
