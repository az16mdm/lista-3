/*-------------------------------------------------------------------
@Lista: 03 - Lógica de Programação
@Autor: Lucas Azevedo Sampaio
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nvl;
        int missao, inmg, final = 0, final1 = 0, final2 = 0, final3 = 0;
        Console.WriteLine(" Quantas missões foram completadas?: ");
        int.TryParse(Console.ReadLine(), out missao);
        for (int i = 0; i < missao; i++)
        {
            Console.WriteLine("Para cada missão, escreva qual o nível de dificuldade?: ");
            nvl = Console.ReadLine();
            if (nvl == "facil")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inmg);
                final = 50 * inmg;
            }
            else if (nvl == "medio")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inmg);
                final1 = 100 * inmg;
            }
            else if (nvl == "dificil")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inmg);
                final2 = 150 * inmg;
            }
            final3 = final + final1 + final2;
        }
        Console.WriteLine($"Você ganhou {final3} pontos");
    }
}
