/*
 * Memorizar 5.1
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


int num;
Console.Write("Insira um numero: ");
num = Convert.ToInt32(Console.ReadLine());
if ((num % 2) == 0)
    Console.WriteLine("O " + num + " e par.");
else
    Console.WriteLine("O " + num + " e impar.");
