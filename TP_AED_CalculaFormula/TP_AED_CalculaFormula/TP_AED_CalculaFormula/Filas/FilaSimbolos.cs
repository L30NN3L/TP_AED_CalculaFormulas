using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula
{
   public class FilaSimbolos
    {

        private ElemSimbolo primeiro, ultimo;

        public ElemSimbolo Primeiro
        {
            get
            {
                return primeiro;
            }

            set
            {
                primeiro = value;
            }
        }

        public ElemSimbolo Ultimo
        {
            get
            {
                return ultimo;
            }

            set
            {
                ultimo = value;
            }
        }

        //  public ElemSimbolo Primeiro { get => primeiro; set => primeiro = value; }
        //   public ElemSimbolo Ultimo { get => ultimo; set => ultimo = value; }

        public FilaSimbolos()
        {
            this.Primeiro = new ElemSimbolo();
            this.Ultimo = this.Primeiro;
        }

        public ElemSimbolo Enfileirar(ElemSimbolo novo)
        {
            this.Ultimo.Proximo = novo;
            this.Ultimo = novo;
            return Ultimo;
        }

        public ElemSimbolo Desenfileirar()
        {
            ElemSimbolo aux = this.Primeiro.Proximo;
            this.Primeiro.Proximo = aux.Proximo;
            aux.Proximo = null;
            return aux;
        }

        public bool FilaVazia()
        {
            if (this.Primeiro.Proximo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ImprimeFila()
        {
            ElemSimbolo aux = this.Primeiro.Proximo;
            while (aux != null)
            {
                Console.Write(" {0},", aux.Simbolo);
                aux = aux.Proximo;
            }
        }

    }
}
