/*
 * Exemplo 5.3
 * Livro: Aprender a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

Console.WriteLine(5 + 3 * 9); //32
Console.WriteLine((5 + 3) * 9); //72		
Console.WriteLine(!false || true); //True (negacao avaliada antes do OU)		
Console.WriteLine(!(false || true)); //False (OU avaliado antes da negacao)
Console.WriteLine(true || false && false); //True (E avaliadao antes do OU)
Console.WriteLine((true || false) && false); //False       
