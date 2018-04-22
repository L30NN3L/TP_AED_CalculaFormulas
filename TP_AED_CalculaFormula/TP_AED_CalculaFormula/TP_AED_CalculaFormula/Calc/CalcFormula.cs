using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula.Calc
{
    public class CalcFormula
    {

       public static void Calcular(ElemFormula form, FilaSimbolos simbolos)
        {

           simbolos = Token.Tokenizer(0, 0, form, simbolos);

            Console.WriteLine("\n\n==========INICIO FORMULA=============\n\n");


            simbolos.ImprimeFila();

            Console.WriteLine("\n\n**********************\n\n");

            simbolos = EmpilhadeiraPolonesa.PosFixa(simbolos);

            simbolos.ImprimeFila();

            double resultado = EmpilhadeiraPolonesa.Calcular(simbolos);

            Console.WriteLine("\n\n**********************\n\n");

            Console.Write("Resultado:"+resultado);

            Console.WriteLine("\n\n==========FIM FORMULA=============\n\n");

        }

        public static void CalcularEmSerie(FilaFormulas filaForm, FilaSimbolos simbolos)
        {

            while (!filaForm.FilaVazia())
            {

                ElemFormula form = filaForm.Desenfileirar();
                Calcular(form, simbolos);

            }

        }

        public static void CalcularEmSerie(FilaFormulas filaForm)
        {

            while (!filaForm.FilaVazia())
            {

                ElemFormula form = filaForm.Desenfileirar();
                Calcular(form, new FilaSimbolos());

            }

        }

    }
}
