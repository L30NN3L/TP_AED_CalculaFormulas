using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula
{
    public class FilaFormulas
    {

        private ElemFormula primeiro, ultimo;

        public ElemFormula Primeiro
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

        public ElemFormula PrimeiroProximo
        {
            get
            {
                return this.primeiro.Proximo;
            }
            set
            {
                this.primeiro.Proximo = value;
            }
        }

        public ElemFormula Ultimo
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

        //  public ElemFormula Primeiro { get => primeiro; set => primeiro = value; }
        //  public ElemFormula Ultimo { get => ultimo; set => ultimo = value; }

        public FilaFormulas()
        {
            this.Primeiro = new ElemFormula();
            this.Ultimo = this.Primeiro;
        }

        public ElemFormula Enfileirar(ElemFormula novo)
        {
            this.Ultimo.Proximo = novo;
            this.Ultimo = novo;
            return Ultimo;
        }

        public ElemFormula Desenfileirar()
        {
            ElemFormula aux = this.Primeiro.Proximo;
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
            ElemFormula aux = this.Primeiro.Proximo;
            while(aux != null)
            {
                Console.Write("\n {0}",aux.Formula);
                aux = aux.Proximo;
            }
        }

        public void lerArquivo(string nomeArquivo)
        {
            //Encoding.UTF8 para formatação correta dos caracteres no console
            StreamReader file = new StreamReader(nomeArquivo, Encoding.UTF8);

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                ElemFormula novo = new ElemFormula(line);
                Enfileirar(novo);
            }

            file.Close();
        }

    }
}
