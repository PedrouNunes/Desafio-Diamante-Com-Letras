using System;

namespace DesafioDiamante2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metade, qntEspacos, posicao = 0, qntEspacosLetra, conta = 0;
            char letra;

            metade = (posicao - 1) / 2;
            qntEspacos = (posicao + posicao) / 2;
            qntEspacosLetra = 0;

            String alfabeto = "ABCDEFGHIJQLMNOPQRSTUVWXYZ";
            char[] alfabeto2 = alfabeto.ToCharArray();

            Console.Write("Digite a letra desejada: ");
            letra = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < alfabeto2.Length; i++)
            {
                if (alfabeto2[i] == letra)
                {
                    posicao = i;
                }
            }
            
            qntEspacos = posicao;
            qntEspacosLetra = 0;

            for (int i = 0; i <= posicao; i++)
            {
                for (int j = 0; j < qntEspacos; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(alfabeto2[i]);

                conta = (2 * i) + 1;
                for (int k = 0; k < qntEspacosLetra; k++)
                {
                    Console.Write(" ");
                }

                if (i != 0)
                {
                    Console.Write(alfabeto2[i]);
                }

                Console.WriteLine();

                qntEspacos = qntEspacos - 1;

                if (i == 0)
                {
                    qntEspacosLetra = 1;
                }
                else if (i != (posicao))
                {
                    qntEspacosLetra = qntEspacosLetra + 2;
                }
            }
            
            letra = Convert.ToChar(letra - 1);
            qntEspacos = 0;

            for (int i = 1; i <= posicao; i++)
            {
                qntEspacos = qntEspacos + 1;
                qntEspacosLetra = qntEspacosLetra - 2;

                for (int j = 0; j < qntEspacos; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(alfabeto2[posicao - i]);

                conta = (2 * i) + 1;
                for (int k = 0; k < qntEspacosLetra; k++)
                {
                    Console.Write(" ");
                }

                if (i != posicao)
                {
                    Console.Write(alfabeto2[posicao - i]);
                }

                Console.WriteLine();
            }

        }
    }
}
