using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboAEB
{
    class Program
    {

        static void Main(string[] args)
        {
            int contadorGrid = 0;
           

                Robo robo1 = new Robo();
                Robo robo2 = new Robo();

                if (contadorGrid < 1)
                {
                    Console.WriteLine("Entre com o tamanho do grid nesse formato (x y)");
                    string grid = Console.ReadLine();
                    contadorGrid++;
                    robo1.gerarGrid(grid);
                    robo2.gerarGrid(grid);
                   
                }
                for (int i = 0; i < 1; i++)
                {
                    robo1.pedirPosicao();

                    do
                    {
                        string comando = "";
                        Console.WriteLine("Entre comando:");
                        comando = Console.ReadLine();

                        robo1.interpretador(comando);
                        if (robo1.validacaParaGrid == true && robo1.validacaoDEM == true)
                        {
                            Console.Write(robo1.x + " ");
                            Console.Write(robo1.y + " ");
                            Console.Write(robo1.orientacao);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (robo1.validacaParaGrid == false || robo1.validacaoDEM == false)
                        {
                            
                            Console.WriteLine("Comando inválido");
                            Console.ReadLine();
                            
                            Console.Clear();
                            

                        }

                    } while (robo1.validacaParaGrid == false || robo1.validacaoDEM == false);

                }
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Segundo robo:");
                    robo2.pedirPosicao();

                    do
                    {
                        string comando = "";
                        Console.WriteLine("Entre comando:");
                        comando = Console.ReadLine();

                        robo2.interpretador(comando);
                        if (robo2.validacaParaGrid == true && robo2.validacaoDEM == true)
                        {
                            Console.Write(robo2.x + " ");
                            Console.Write(robo2.y + " ");
                            Console.Write(robo2.orientacao);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (robo2.validacaParaGrid == false || robo2.validacaoDEM == false)
                        {
                            Console.WriteLine("Comando inválido: valor não corresponde a: D,E ou M!");
                            Console.ReadLine();
                            Console.Clear();
                        }

                    } while (robo2.validacaParaGrid == false || robo2.validacaoDEM == false);

                }
                









            }
        }
    }

