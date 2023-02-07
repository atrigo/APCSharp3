/*
 * Memorizar 6.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

int numero, contar = 0, soma = 0;
float media;
do
{
    Console.Write("Insira um numero:");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero != 0)
    {
        contar++;
        soma += numero;
    }
} while (numero != 0);
media = (float)soma / contar;
Console.WriteLine("A media dos numeros inseridos e {0}.", media);
