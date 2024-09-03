/*-------------------------------------------------------------------
@Lista: 01 - Lógica de Programação
@Autor: Lucas Azevedo Sampaio
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? diasBonus;
        int dias, pdia, dconsecutivo = 0, bonus = 0, final1 = 0, final2 = 0, valor = 0, final3 = 0;
        Console.WriteLine("escreva quantos dias consecutivos você logou no jogo?");
        int.TryParse(Console.ReadLine(), out dias);
        Console.WriteLine("escreva qual foi recompensa inicial em moedas no primeiro dia?");
        int.TryParse(Console.ReadLine(), out pdia);
        Console.WriteLine("escreva qual foi incremento da recompensa a cada dia consecutivo?");
        int.TryParse(Console.ReadLine(), out dconsecutivo);
        Console.WriteLine("deseja considerar bônus por marcos de dias?");
        diasBonus = Console.ReadLine();
        if (diasBonus == "sim")
        {
            Console.WriteLine("Qual o valor do bônus?");
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine(" escreva quantos dias consecutivos há um bônus: ");
            int.TryParse(Console.ReadLine(), out bonus);
        }
        final3 = valor * bonus;
        final1 = dias * dconsecutivo;
        final2 = final1 + pdia + final3;
        System.Console.WriteLine($"Você tem {final2} pontos");
    }
}