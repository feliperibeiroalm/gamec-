using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            string[,] velha = new string[3, 3];
            int p = 0, jogada=0;
            bool fim=false;
            string vencedor="EMPATE";

            Console.WriteLine("\tJOGO DA VELHA");
            Console.WriteLine();

            for (int i=0;i<=2;i++)
            {
                for (int j=0;j<=2;j++)
                {
                    p++;
                    velha[i,j]=Convert.ToString(p);
                }
            }

            for (int i=0;i<=2;i++)
            {
                for (int j=0;j<=2;j++)
                {
                    Console.Write("\t{0}",velha[i,j]);
                }
                 Console.WriteLine();
                 Console.WriteLine();
            }


            Console.WriteLine("Digite o número referente a casa que pretende jogar:" );

            do
            {
                do
                {
                    Console.WriteLine("Vez do jogador X -- (Digite entre 1 e 9 - Somente casas não jogadas ainda)");
                    jogada = int.Parse(Console.ReadLine());
                }
                while (jogada < 1 || jogada > 9);
                
                switch(jogada)
                {
                    case 1: velha[0, 0] = "X"; break;
                    case 2: velha[0, 1] = "X"; break;
                    case 3: velha[0, 2] = "X"; break;
                    case 4: velha[1, 0] = "X"; break;
                    case 5: velha[1, 1] = "X"; break;
                    case 6: velha[1, 2] = "X"; break;
                    case 7: velha[2, 0] = "X"; break;
                    case 8: velha[2, 1] = "X"; break;
                    case 9: velha[2, 2] = "X"; break;
                }

                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.Write("\t{0}", velha[i, j]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                // HORIZONTAIS
                if (velha[0, 0] == "X" && velha[0, 1] == "X" && velha[0, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[1, 0] == "X" && velha[1, 1] == "X" && velha[1, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[2, 0] == "X" && velha[2, 1] == "X" && velha[2, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }

                //VERTICAIS
                if (velha[0, 0] == "X" && velha[1, 0] == "X" && velha[2, 0] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[0, 1] == "X" && velha[1, 1] == "X" && velha[2, 1] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[0, 2] == "X" && velha[1, 2] == "X" && velha[2, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }

                //DIAGONAIS
                if (velha[0, 0] == "X" && velha[1, 1] == "X" && velha[2, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[2, 0] == "X" && velha[1, 1] == "X" && velha[0, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }

                do
                {
                    Console.WriteLine("Vez do jogador O -- (Digite entre 1 e 9 - Somente casas não jogadas ainda)");
                    jogada = int.Parse(Console.ReadLine());
                }
                while (jogada < 1 || jogada > 9);

                switch (jogada)
                {
                    case 1: velha[0, 0] = "O"; break;
                    case 2: velha[0, 1] = "O"; break;
                    case 3: velha[0, 2] = "O"; break;
                    case 4: velha[1, 0] = "O"; break;
                    case 5: velha[1, 1] = "O"; break;
                    case 6: velha[1, 2] = "O"; break;
                    case 7: velha[2, 0] = "O"; break;
                    case 8: velha[2, 1] = "O"; break;
                    case 9: velha[2, 2] = "O"; break;
                }

                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.Write("\t{0}", velha[i, j]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                // HORIZONTAIS
                if (velha[0, 0] == "O" && velha[0, 1] == "O" && velha[0, 2] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }
                if (velha[1, 0] == "O" && velha[1, 1] == "O" && velha[1, 2] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }
                if (velha[2, 0] == "O" && velha[2, 1] == "O" && velha[2, 2] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }

                //VERTICAIS
                if (velha[0, 0] == "O" && velha[1, 0] == "O" && velha[2, 0] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }
                if (velha[0, 1] == "O" && velha[1, 1] == "O" && velha[2, 1] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }
                if (velha[0, 2] == "O" && velha[1, 2] == "O" && velha[2, 2] == "O")
                {
                    fim = true;
                    vencedor = "O";
                    goto fim;
                }

                //DIAGONAIS
                if (velha[0, 0] == "X" && velha[1, 1] == "X" && velha[2, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }
                if (velha[2, 0] == "X" && velha[1, 1] == "X" && velha[0, 2] == "X")
                {
                    fim = true;
                    vencedor = "X";
                    goto fim;
                }



            } while (fim != true);

        fim:
            
            
            
            Console.ReadKey();
        }
    }
}
