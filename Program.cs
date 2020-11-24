using System;

namespace ExercicioTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Tabuada C#");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("----------------------");
                for (int j = 0; j < 11; j++)
                {
                    
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("----------------------");
            }
        }
    }
}
