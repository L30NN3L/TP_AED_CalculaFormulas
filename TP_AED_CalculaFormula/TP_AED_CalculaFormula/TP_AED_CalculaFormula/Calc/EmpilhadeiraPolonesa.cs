using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_AED_CalculaFormula.Elementos;

namespace TP_AED_CalculaFormula.Calc
{
   public class EmpilhadeiraPolonesa
    {

        public static FilaSimbolos PosFixa(FilaSimbolos fila)
        {

            PilhaOperadores pilhaOp = new PilhaOperadores();
            FilaSimbolos filaPosFixa = new FilaSimbolos();
            int prioridadeTopo = 0;

            while (!fila.FilaVazia())
            {

                ElemSimbolo elem = fila.Desenfileirar();

                if (Validador.EhOperador(elem.Simbolo))
                {

                    ElementOp aux = new ElementOp(elem.Simbolo);

                    if (pilhaOp.Peek() != null)
                    {
                        prioridadeTopo = pilhaOp.Peek().Prioridade;
                    }
                    else
                    {
                        prioridadeTopo = 0;
                    }

                    if (aux.Prioridade <= prioridadeTopo && aux.Simbolo != ")" && aux.Simbolo != "(")
                    {
                        filaPosFixa.Enfileirar(pilhaOp.Pop());
                        pilhaOp.Push(aux);
                    }
                    else if (aux.Prioridade > prioridadeTopo || aux.Simbolo == "(")
                    {
                        pilhaOp.Push(aux);
                    }
                    else if (aux.Simbolo == ")")
                    {
                        while (pilhaOp.Peek().Simbolo != "(")
                        {
                            filaPosFixa.Enfileirar(pilhaOp.Pop());
                        }
                        pilhaOp.Pop();

                    }

                }
                else
                {
                    filaPosFixa.Enfileirar(elem);
                }
            }

            while(pilhaOp.Peek() != null)
            {
                filaPosFixa.Enfileirar(pilhaOp.Pop());
            }


            return filaPosFixa;

        }


        public static double Calcular(FilaSimbolos fila)
        {

            PilhaNumeros pilha = new PilhaNumeros();

            while (!fila.FilaVazia())
            {

                ElemSimbolo aux = fila.Desenfileirar();

                if (!Validador.EhOperador(aux.Simbolo))
                {
                    pilha.Push(new EleNumber(aux.Simbolo));
                }
                else
                {
                    EleNumber numberB = pilha.Pop();
                    EleNumber numberA = pilha.Pop();

                    double result = 0;

                    switch (aux.Simbolo)
                    {
                        case "+":
                            result = numberA.Dado + numberB.Dado;  
                            break;
                        case "-":
                            result = numberA.Dado - numberB.Dado;
                            break;
                        case "*":
                            result = numberA.Dado * numberB.Dado;
                            break;
                        case "/":
                            result = numberA.Dado / numberB.Dado;
                            break;
                        case "^":
                            result = Math.Pow(numberA.Dado, numberB.Dado);
                            break;
                        case "√":
                            pilha.Push(numberA);
                            result = Math.Sqrt(numberB.Dado);
                            break;
                        case "l":
                            pilha.Push(numberA);
                            result = Math.Log10(numberB.Dado);
                            break;
                    }

                    EleNumber eleNumber = new EleNumber(result);
                    pilha.Push(eleNumber);
                }

            }

            return pilha.Pop().Dado;
        }


       

    }
}
