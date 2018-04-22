using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_AED_CalculaFormula.Calc;

namespace TP_AED_CalculaFormula
{
    class Token
    {
        

        public static FilaSimbolos Tokenizer(int ini, int fim, ElemFormula form, FilaSimbolos simb)
        {

           

            string coisa;
            if (ini >= form.Formula.Length)
            {
                return simb;
            }
            if ((fim + 1) < form.Formula.Length)
            {
                if ((Validador.EhOperador(form.Formula[fim].ToString()) == false))
                {
                    if (Validador.EhOperador(form.Formula[fim + 1].ToString()) == false)
                    {
                        return Tokenizer(ini, (fim + 1), form, simb);
                    }
                    else
                    {
                        coisa = "";
                        for (int i = ini; i <= fim; i++)
                        {
                            coisa = coisa + form.Formula[i];
                        }
                        simb.Enfileirar(new ElemSimbolo(coisa));
                        fim++;
                        ini = fim;
                        return Tokenizer(ini, fim, form, simb);
                    }
                }
                else
                {
                    simb.Enfileirar(new ElemSimbolo(form.Formula[fim].ToString()));
                    fim++;
                    ini = fim;
                    return Tokenizer(ini, fim, form, simb);
                }

            }
            else
            {
                if (Validador.EhOperador(form.Formula[fim].ToString()) == false)
                {
                    coisa = "";
                    for (int i = ini; i <= fim; i++)
                    {
                        coisa = coisa + form.Formula[i];
                    }
                    simb.Enfileirar(new ElemSimbolo(coisa));
                    fim++;
                    ini = fim;
                    return Tokenizer(ini, fim, form, simb);
                }
                else
                {
                    simb.Enfileirar(new ElemSimbolo(form.Formula[fim].ToString()));
                    fim++;
                    ini = fim;
                    return Tokenizer(ini, fim, form, simb);
                }
            }



        }


        //char[] numero = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };
        //resp[pos] = forma[fim].ToString();
        //pos = pos + 1;
        //lug = sinal.Length;
        //static void Main(string[] args)
        //{

        //    string bla = "25/2+1";
        //    string[] f = new string[bla.Length];
        //    f = colocar(0, 0, bla, f, 0);
        //    for (int i = 0; i < f.Length; i++)
        //    {
        //        Console.WriteLine(f[i]);
        //    }
        //    Console.ReadKey();
        //}
    }
}
