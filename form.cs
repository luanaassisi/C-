// Obtendo informações dos usuários

namespace ExempleAppConsole
{
    class Program
    {
        static void Main(string[]args)
        {
        String nome;
        int idade;

        Console.WriteLine("Digite o seu nome");
        nome = Console.readLine();

        Console.WriteLine("Digite a sua idade");
        idade = Convert.Toint32(Console.readLine());

        int dias = idade * 365;
        console.WriteLine("Olá {0} Você já viveu {1} dias!!", nome, dias);
        Console.readLine();
        }
    }
}

