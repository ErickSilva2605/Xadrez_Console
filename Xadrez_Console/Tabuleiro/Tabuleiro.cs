using tabuleiro.Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //Sobrepociçao do metodo GetPeca
        public Peca GetPeca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public Peca RemoverPeca(Posicao pos)
        {
            if (GetPeca(pos) == null)
            {
                return null;
            }

            Peca aux = GetPeca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public void SetPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabulerioException("Já existe uma peça nesta posição");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return pecas[pos.Linha, pos.Coluna] != null;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabulerioException("Posição Invalida!");
            }
        }
    }
}
