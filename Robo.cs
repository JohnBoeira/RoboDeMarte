using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboAEB
{
    public class Robo
    {
        public uint x = 0, y = 0;
        public char orientacao;
        public uint xgrid = 0, ygrid = 0;
        public bool validacaParaGrid = true, validacaoDEM = true;
        public string posicaoInicial;       

        public void gerarGrid(string grid)
        {
            grid.Replace(" ", "");
            char[] charGrid = grid.ToCharArray();

            xgrid = (uint)Char.GetNumericValue(charGrid[0]);
            ygrid = (uint)Char.GetNumericValue(charGrid[2]);
            
        }

        public void pedirPosicao()
        {

            Console.WriteLine("Entre com a posição inicial: ");
            posicaoInicial = Console.ReadLine();
            char[] charPos = posicaoInicial.ToCharArray();
            char orientac = posicaoInicial[4];

            

             uint px= (uint)Char.GetNumericValue(charPos[0]);
            uint py = (uint)Char.GetNumericValue(charPos[2]);

            gerarPosicao(px, py, orientac);
        }

        public void gerarPosicao(uint px, uint py, char orientac)
        {
            x = px;
            y = py;
            
            orientacao = orientac;
        }

        public void interpretador(string comando)
        {
            string cmd = comando.ToUpper();
            char[] charCmd = cmd.ToCharArray();

            foreach (var ch in charCmd)
            {
                if (ch == 'E')
                {
                    validacaoDEM = true;
                    if (orientacao == 'N' || orientacao == 'n')
                    {
                        orientacao = 'O';
                    }
                    else if (orientacao == 'L' || orientacao == 'l')
                    {
                        orientacao = 'N';
                    }
                    else if (orientacao == 'S' || orientacao == 's')
                    {
                        orientacao = 'L';
                    }
                    else if (orientacao == 'O' || orientacao == 'o')
                    {
                        orientacao = 'S';
                    }
                }
                if (ch == 'D')
                {
                    validacaoDEM = true;
                    if (orientacao == 'N' || orientacao == 'n')
                    {
                        orientacao = 'L';
                    }
                    else if (orientacao == 'L' || orientacao == 'l')
                    {
                        orientacao = 'S';
                    }
                    else if (orientacao == 'S' || orientacao == 's')
                    {
                        orientacao = 'O';
                    }
                    else if (orientacao == 'O' || orientacao == 'o')
                    {
                        orientacao = 'N';
                    }
                }
                if (ch == 'M')
                {
                    validacaoDEM = true;
                    if (orientacao == 'N' || orientacao == 'n')
                    {
                        if (y <= ygrid)
                        {
                            y++;                          
                        }
                        else
                        {
                            
                            validacaParaGrid = false;
                            break;
                            
                        }
                    }

                    else if (orientacao == 'L' || orientacao == 'l')
                    {
                        if (x <= xgrid)
                        {
                            x++;
                        }
                        else
                        {
                            
                            validacaParaGrid = false;
                            break;
                            
                        }
                    }

                    else if (orientacao == 'S' || orientacao == 's')
                    {
                        if (y != 0)
                        {
                            y--;
                        }
                        else
                        {
                            
                            validacaParaGrid = false;
                            break;
                           
                        }
                    }
                    else if (orientacao == 'O' || orientacao == 'o')
                    {
                        if (x != 0)
                        {
                            x--;
                        }
                        else
                        {
                            
                            validacaParaGrid = false;
                            break;
                            
                        }
                    }
                }
                else if (ch != 'M')
                {
                    if (ch != 'D')
                    {
                        if (ch != 'E')
                        {
                            
                            validacaoDEM = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
