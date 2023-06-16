﻿using System;

class Program {
  public static void Main (string[] args) {
    
  
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-- Média da nota final --\n");
            Console.ResetColor();

            decimal nota1, nota2, nota3, nota4, media;
            string resultado;

            Console.Write("Digite a primeira nota..: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a segunda nota...: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a terceira nota..: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quarta nota....: ");
            nota4 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            bool todasNotasSaoValidas = nota1 >= 0 && nota1 <= 10
                                     && nota2 >= 0 && nota2 <= 10
                                     && nota3 >= 0 && nota3 <= 10
                                     && nota4 >= 0 && nota4 <= 10;
            if (todasNotasSaoValidas)
            {
                media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (media < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    resultado = "Reprovado";
                }
                else
                {
                    if (media > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        resultado = "Aprovado";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        resultado = "Em recuperação";
                    }
                }
                Console.WriteLine($"Sua media final foi {media} / Resultado -> {resultado}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("-- Atenção : Sua nota não foi computada, é necessário digitar números entre 0 a 10 --\n".ToUpper());
            }
            Console.ResetColor();
        }
    }

