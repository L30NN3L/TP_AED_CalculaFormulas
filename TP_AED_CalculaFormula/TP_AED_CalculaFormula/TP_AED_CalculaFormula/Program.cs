using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\tTRABALHO DE AED - CALCULADOR DE FÓRMULAS\n\tINTEGRANTES DO GRUPO:\n\tHugo Leonel\n\tVictoria Lopes\n\tLuiz Otávio\n\tFelipe Massato");


            Menu();

        }


        static void Menu()
        {
            int opcao;
            FilaFormulas formulas = new FilaFormulas();
            //  FilaSimbolos simbolos = new FilaSimbolos();
            Token token = new Token();

            do
            {
                Console.Write("\n\tDigite:");
                Console.Write("\n\t0 - para sair; ");
                Console.Write("\n\t1 - para importar expressões via arquivo; ");
                Console.Write("\n\t2 - para inserir expressões via console; ");
                Console.Write("\n\t3 - para calcular as expressões");
                Console.Write("\n\n\tOpção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        formulas.lerArquivo("expressoes.txt");
                        Console.WriteLine("\nFormulas importadas!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\nDigite uma expressão matemática: ");      
                        formulas.Enfileirar(new ElemFormula(Console.ReadLine()));
                        Console.WriteLine("\nFormula importada!");
                        break;
                    case 3:
                        Calc.CalcFormula.CalcularEmSerie(formulas);
                        break;
                }
            } while (opcao != 0);

            Console.ReadKey();
        }

   
    }
}
