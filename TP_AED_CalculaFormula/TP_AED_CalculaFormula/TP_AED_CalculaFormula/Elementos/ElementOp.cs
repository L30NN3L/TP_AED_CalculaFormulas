using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula.Elementos
{
    public class ElementOp : ElemSimbolo
    {

      //  private string operador;
        private int prioridade;

      //  private ElementOp proximo;

     //   public ElementOp Proximo { get => proximo; set => proximo = value; }

     //   public string Dado { get => operador; set => operador = value; }
  
            
            // ainda pode ser útil nesta classe  *->  public int Prioridade { get => prioridade; set => prioridade = value; }

        public ElementOp()
        {

        }

        public ElementOp(string dado)
        {
            this.Simbolo = dado;

            switch (dado)
            {
                case "+":
                    this.Prioridade = 1;
                    break;
                case "-":
                    this.Prioridade = 1;
                    break;
                case "*":
                    this.Prioridade = 2;
                    break;
                case "/":
                    this.Prioridade = 2;
                    break;
                case "(":
                    this.Prioridade = 0;
                    break;
                case ")":
                    this.Prioridade = 0;
                    break;
                case "^":
                    this.Prioridade = 3;
                    break;
                case "√":
                    this.Prioridade = 3;
                    break;
                case "l":
                    this.Prioridade = 3;
                    break;

            }

        }

        public int Prioridade
        {
            get
            {
                return prioridade;
            }

            set
            {
                prioridade = value;
            }
        }
    }
}
