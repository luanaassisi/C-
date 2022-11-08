// using System;

// namespace Aula06
// {

//     class Program
//     {

//         static void Main(String[] args)
//         {

//             Console.Write("Digite um número entre 1 e 10: ");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int hora = DateTime.Now.Hour;
//             string mensagem = string.Empty;
//             switch (hora)
//             {
//                 case 10:
//                 case 15:
//                 mensagem ="hora do intervalo";
//                 break;
//                 case 12:
//                 mensagem = "Almoço";
//                 break;
//                 default:
//                 mensagem =string.Empty;
//                 break;
//             }

//             if(hora > 17){
//                 Console.WriteLine("Boa noite!");
//             }
//             else if (hora > 11)
//             {
//                 Console.WriteLine("Boa tarde!");
//             }
//             else
//             {
//                 Console.WriteLine("Bom dia!");
//             }
//             if (n > 10 || n < 1)
//             {
//                 Console.WriteLine("Digite um número válido!");
//             }
//             else
//             {
//                 Console.WriteLine("Obrigada!");

//             }
//             Console.ReadLine();

//         }
//     }

// }