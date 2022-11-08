using System;

namespace Aula07
{

    class Program
    {

        static void Main(String[] args)
        {
            int tabuada;
            Console.Write("Qual a tabuada");
            tabuada = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++){
                Console.WriteLine("{0} x {1} = {2}", tabuada, i , i* tabuada);
            }
            Console.ReadLine();
        }  
    }

}