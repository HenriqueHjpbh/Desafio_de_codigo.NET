using System;
using System.Collections.Generic;

internal class NewBaseType
{
    static void Main(string[] args)
    {

        int suavariavel = int.Parse(Console.ReadLine());
        string[] arrayString = Console.ReadLine().Split(' ');
        List<int> listaNumeros = new List<int>();
        foreach (string item in arrayString)
        {
            listaNumeros.Add(int.Parse(item));
        }


        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;
        //TODO: Complete os espaços em branco com uma possível solução para o desafio
        foreach (int numero in listaNumeros)
        {
            if (numero % 2 == 0)
            {
                multiplo2++;
            }
            if (numero % 3 == 0)
            {
                multiplo3++;
            }
            if (numero % 4 == 0)
            {
                multiplo4++;
            }
            if (numero % 5 == 0)
            {
                multiplo5++;
            }
        }

        Console.WriteLine($"{multiplo2} Multiplo(s) de 2", multiplo2);
        Console.WriteLine($"{multiplo3} Multiplo(s) de 3", multiplo3);
        Console.WriteLine($"{multiplo4} Multiplo(s) de 4", multiplo4);
        Console.WriteLine($"{multiplo5} Multiplo(s) de 5", multiplo5);
    }
}
