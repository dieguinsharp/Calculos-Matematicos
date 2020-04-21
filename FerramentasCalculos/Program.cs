using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentasCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "<< Calculos Matemáticos em C# - Distek >>";
            string opc;
            do
            {
                int resp = 0;
                Console.WriteLine("*--------------- Calculos Matemáticos - Escritos em C# ---------------*");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[01]-- Achar o Delta -----------------------------------------[01]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[02]-- Achar o X' e X'' --------------------------------------[02]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[03]-- Achar o lado do tringulo retângulo (Pitágoras) --------[03]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[04]-- Achar o Baricentro do Triangulo (Pontos) --------------[04]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[05]-- Achar a distancia entre 2 pontos ----------------------[05]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[06]-- Sistemas envolvendo 2 incógnitas (1o Grau) ------------[06]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[07]-- Área de um triangulo retângulo com seus pontos (SARRI) [07]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[08]-- Calcular o Vértice de X -------------------------------[08]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[09]-- Calcular o Vértice de Y -------------------------------[09]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[10]- Achar o Coeficiente angular de uma Eq da 1o Grau -------[10]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("|-[11]- Ponto médio entre 2 pontos -----------------------------[11]--|");
                Console.WriteLine("|---------------------------------------------------------------------|");
                Console.WriteLine("-----------------------------------------------------------------------");

                Console.Write(">> O que deseja calcular?");
                bool error = false;
                try {
                    resp = int.Parse(Console.ReadLine());
                    Console.Clear();
                } catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida!");
                    error = true;
                }
                if (error == false) {
                    switch (resp) {
                        case 1:
                            string resp1;
                            double a, b, c, delt;
                            do {
                                Console.WriteLine("--- Achar o Delta ---");
                                Console.Write("Digite o valor de A:");
                                a = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de B:");
                                b = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de C:");
                                c = double.Parse(Console.ReadLine());

                                delt = (b * b) - 4 * a * c;
                                Console.WriteLine();
                                Console.WriteLine("Valor do delta é " + delt + ".");
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp1 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp1 != "N");
                            break;
                        case 2:
                            string resp2;
                            double a2, b2, delt2;
                            do {
                                Console.WriteLine("--- Achar o X' e X'' ---");
                                Console.Write("Digite o valor de A:");
                                a2 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de B:");
                                b2 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de Delta:");
                                delt2 = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                                double xx1, xx2, div1, div2;
                                xx1 = ((-b2) + Math.Sqrt(delt2));
                                div1 = xx1;
                                xx2 = ((-b2) - Math.Sqrt(delt2));
                                div2 = xx2;

                                xx1 = (xx1) / (2 * a2);
                                xx2 = (xx2) / (2 * a2);

                                Console.WriteLine("Antes da divisão, o valor de X' foi " + div1 + "/" + (2 * a2) + ", e o valor de X'' foi " + div2 + "/" + (2 * a2) + ".");
                                Console.WriteLine("O Valor de X' é " + xx1 + " e o valor de X'' é " + xx2 + ".");
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp2 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp2 != "N");
                            break;
                        case 3:
                            string resp3;
                            double CatOposto, CatAdj, Hip;
                            do {
                                Console.WriteLine("--- Achar o lado do triangulo retângulo (Pitágoras) ---");
                                Console.WriteLine("--- [Favor colocar 0 na incógnita a ser procurada] ---");
                                Console.Write("Digite o valor de Cat Oposto:");
                                CatOposto = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de Cat Adjacente:");
                                CatAdj = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de Hipotenusa:");
                                Hip = double.Parse(Console.ReadLine());

                                if (Hip == 0) {
                                    double hip1;
                                    hip1 = Math.Sqrt((CatOposto * CatOposto) + (CatAdj * CatAdj));
                                    Console.WriteLine("O valor da hipotenusa é " + hip1 + ".");
                                } else if (CatAdj == 0) {
                                    double cat;
                                    cat = Math.Sqrt((Hip * Hip) - (CatOposto * CatOposto));
                                    Console.WriteLine("O valor do cateto é " + cat + ".");
                                } else if (CatOposto == 0) {
                                    double cat;
                                    cat = Math.Sqrt((Hip * Hip) - (CatAdj * CatAdj));
                                    Console.WriteLine("O valor do cateto é " + cat + ".");
                                } else {
                                    Console.WriteLine("Digite um valor válido!");
                                }
                                Console.WriteLine();
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp3 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp3 != "N");
                            break;
                        case 4:
                            string resp4;
                            double x1, x2, x3, y1, y2, y3, bx, by;
                            do {
                                Console.WriteLine("--- Achar o Baricentro do Triangulo(Pontos) ---");
                                Console.Write("1o Ponto: Valor de X:");
                                x1 = double.Parse(Console.ReadLine());
                                Console.Write("1o Ponto: Valor de Y:");
                                y1 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Valor de X:");
                                x2 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Valor de Y:");
                                y2 = double.Parse(Console.ReadLine());
                                Console.Write("3o Ponto: Valor de X:");
                                x3 = double.Parse(Console.ReadLine());
                                Console.Write("3o Ponto: Valor de Y:");
                                y3 = double.Parse(Console.ReadLine());

                                bx = (x1 + x2 + x3) / 3;
                                by = (y1 + y2 + y3) / 3;
                                Console.WriteLine();
                                Console.WriteLine("O baricentro do triangulo está localizado em (" + bx + ";" + by + ").");
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp4 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp4 != "N");
                            break;
                        case 5:
                            string resp5;
                            double xp1, yp1, xp2, yp2, d;
                            do {
                                Console.WriteLine("--- Achar a distancia entre 2 pontos ---");
                                Console.Write("1o Ponto: Valor de X:");
                                xp1 = double.Parse(Console.ReadLine());
                                Console.Write("1o Ponto: Valor de Y:");
                                yp1 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Valor de X:");
                                xp2 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Valor de Y:");
                                yp2 = double.Parse(Console.ReadLine());
                                Console.WriteLine();
                                d = Math.Sqrt((((xp2 * xp2) - (xp1 * xp1))) + (((yp2 * yp2) - (yp1 * yp1))));
                                Console.WriteLine("A distancia entre os pontos é {0}.", d);
                                Console.WriteLine();
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp5 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp5 != "N");
                            break;
                        case 6:
                            string resp6;
                            double ax1, ay1, int1, bx2, by2, int2, x, y;
                            do {
                                Console.WriteLine("--- Sistemas envolvendo 2 incógnitas (1o Grau) ---");
                                Console.WriteLine("Sistema padrão eq 1o grau:");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("---- AX + BY = NUMERO1 ---");
                                Console.WriteLine("---- CX + DY = NUMERO2 ---");
                                Console.WriteLine("--------------------------");
                                Console.WriteLine("OBS: Caso não tiver tal valor, preencha com 0!");
                                Console.Write("Digite o valor de AX");
                                ax1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de BY:");
                                ay1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de NUMERO1:");
                                int1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de CX:");
                                bx2 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de DY:");
                                by2 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de NUMERO2:");
                                int2 = double.Parse(Console.ReadLine());

                                x = ((ay1 * int2) - (by2 * int1)) / ((ay1 * bx2) - (ax1 * by2));
                                y = ((ax1 * x) - int1) / -(ay1);
                                Console.WriteLine();
                                Console.WriteLine("O Valor de X é {0} e o valor de y é {1}.", x, y);
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp6 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp6 != "N");
                            break;
                        case 7:
                            string resp7;
                            double px1, py1, px2, py2, px3, py3, at;
                            do {
                                Console.WriteLine("--- Área de um triangulo retângulo com seus pontos (SARRI) ---");
                                Console.Write("1o Ponto: Digite o valor de X:");
                                px1 = double.Parse(Console.ReadLine());
                                Console.Write("1o Ponto: Digite o valor de Y:");
                                py1 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Digite o valor de X:");
                                px2 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Digite o valor de Y:");
                                py2 = double.Parse(Console.ReadLine());
                                Console.Write("3o Ponto: Digite o valor de X:");
                                px3 = double.Parse(Console.ReadLine());
                                Console.Write("3o Ponto: Digite o valor de Y:");
                                py3 = double.Parse(Console.ReadLine());
                                at = (((px1 * py2 * 1) + (py1 * 1 * px3) + (1 * px2 * py3)) + (-(px3 * py2 * 1)) + (-(py3 * 1 * px1)) + (-(1 * px2 * py1))) / 2;
                                Console.WriteLine();
                                Console.WriteLine("A área do triangulo é {0} unidades de área.", at);

                                Console.Write("Deseja calcular novamente? S/N:");
                                resp7 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp7 != "N");
                            break;
                        case 8:
                            string resp8;
                            double vbx, vax, vx;
                            do {
                                Console.WriteLine("--- Calcular o Vértice de X ---");
                                Console.Write("Digite o valor de A:");
                                vax = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de B:");
                                vbx = double.Parse(Console.ReadLine());

                                vx = (-vbx) / 2 * vax;
                                Console.WriteLine();
                                Console.WriteLine("O vértice de X é {0}.", vx);
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp8 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp8 != "N");
                            break;
                        case 9:
                            string resp9;
                            double vbd, vxa, vy;
                            do {
                                Console.WriteLine("--- Calcular o Vértice de Y ---");
                                Console.Write("Digite o valor de A:");
                                vxa = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de Delta:");
                                vbd = double.Parse(Console.ReadLine());

                                vy = (-vbd) / 4 * vxa;
                                Console.WriteLine();
                                Console.WriteLine("O vértice de Y é {0}.", vy);
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp9 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp9 != "N");
                            break;
                        case 10:
                            string resp10;
                            double xc, yc, ca;
                            do {
                                Console.WriteLine("--- Achar o Coeficiente angular de uma Eq da 1o Grau ---");
                                Console.Write("Digite o valor de X:");
                                xc = double.Parse(Console.ReadLine());
                                Console.Write("Digite o valor de Y:");
                                yc = double.Parse(Console.ReadLine());

                                ca = (-xc) / (yc);
                                Console.WriteLine();
                                Console.WriteLine("O coeficiente angular da Eq é {0}.", ca);
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp10 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp10 != "N");
                            break;
                        case 11:
                            string resp11;
                            double pmx1, pmy1, pmx2, pmy2, pmx, pmy;
                            do {
                                Console.WriteLine("--- Ponto médio entre 2 pontos ---");
                                Console.Write("1o Ponto: Digite o valor de X:");
                                pmx1 = double.Parse(Console.ReadLine());
                                Console.Write("1o Ponto: Digite o valor de Y:");
                                pmy1 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Digite o valor de X:");
                                pmx2 = double.Parse(Console.ReadLine());
                                Console.Write("2o Ponto: Digite o valor de Y:");
                                pmy2 = double.Parse(Console.ReadLine());

                                pmx = (pmx1 + pmx2) / 2;
                                pmy = (pmy1 + pmy2) / 2;

                                Console.WriteLine();
                                Console.WriteLine("O Ponto médio entre os 2 pontós é ({0};{1}).", pmx, pmy);
                                Console.Write("Deseja calcular novamente? S/N:");
                                resp11 = Console.ReadLine();
                                Console.Clear();
                            }
                            while (resp11 != "N");
                            break;
                            default: {
                                Console.WriteLine("Digite um valor dentro das opções!", "Distek");
                                break;
                            }
                    }
                }
                Console.Write("Deseja voltar ao menu? S/N:");
                opc = Console.ReadLine();
                Console.Clear();
            }
            while (opc != "N" && opc != "n");
            Console.WriteLine();
            Console.WriteLine("Muito obrigado por usar nosso Algoritmo XD");

            Console.ReadKey();
        }
    }
}
