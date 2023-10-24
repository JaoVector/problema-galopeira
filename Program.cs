using System;

class Program
{
    static void Main(string[] args) { 
        
        Console.Write("Quantidade de Casos: ");
        var C = Convert.ToInt32(Console.ReadLine());

        string[] Palavras = new string[C];
        
        for(int i = 0; i < C; i++)
        {   
            Console.Write("Digite a Palavra: ");
            string? palavra = Console.ReadLine();
            if(palavra.Length >= 9 && palavra.Length <= 10000)
                Palavras[i] = palavra;
            else
                C = -1;
        }   

        for(int j = 0; j < Palavras.Length; j++)
        {
            if(Palavras[j] != null)
            {
                var T = (float)Palavras[j].Length / 100;
                Console.WriteLine($"{T}");
            }
            
        }
    }   
}
