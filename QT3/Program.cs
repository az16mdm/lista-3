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
        string? nivel;
        int itens, intr, quant, ttl = 0;
        Console.WriteLine(" qual a quantidade de tipos diferentes de itens ele deseja armazenar no inventário: ");
        int.TryParse(Console.ReadLine(), out itens);
        Console.WriteLine(" e qual é a capacidade máxima do inventário: ");
        int.TryParse(Console.ReadLine(), out intr);
        for (int i = 0; i < itens; i++)
        {
            Console.WriteLine("qual o nome do item?");
            nivel = Console.ReadLine();
            Console.WriteLine("quantos itens desse tipo ele possui: ");
            int.TryParse(Console.ReadLine(), out quant);
            ttl += quant;
        }
        if (ttl <= intr)
        {
            Console.WriteLine($"Tem-se {ttl} itens,Dentro da capacidade");
        }
        else
        {
            Console.WriteLine($"Tem-se {ttl} itens,fora da capacidade");
        }
    }
}