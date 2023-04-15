using tabuleiro;
using xadrex_console;
using xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('c', 7);

        Console.WriteLine(pos);

        Console.WriteLine(pos.toPosicao());

        Console.WriteLine();
    }
}