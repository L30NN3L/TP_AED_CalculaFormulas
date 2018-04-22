using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula.Calc
{
    public class Validador
    {

        //public static bool verificar(string comparado)
        //{
        //    char[] sinal = { '+', '-', '*', '/', '^', '(', ')', '√', 'l' };

        //    for (int i = 0; i < sinal.Length; i++)
        //    {
        //        if (comparado == sinal[i].ToString())
        //        {
        //            return true;

        //        }
        //    }
        //    return false;

        //}


       public static bool EhOperador(string simbolo)
        {
            switch (simbolo)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
                case "(":
                    return true;
                case ")":
                    return true;
                case "^":
                    return true;
                case "√":
                    return true;
                case "l":
                    return true;
                default:
                    return false;
            }

        }


    }
}
