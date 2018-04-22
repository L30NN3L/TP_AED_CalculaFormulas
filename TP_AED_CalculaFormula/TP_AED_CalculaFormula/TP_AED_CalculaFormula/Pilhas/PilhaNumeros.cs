using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_AED_CalculaFormula.Elementos;

namespace TP_AED_CalculaFormula
{
    class PilhaNumeros
    {

        private EleNumber topo;

        public PilhaNumeros()
        {
            this.topo = new EleNumber();
        }

        public EleNumber Push(EleNumber novo)
        {
            novo.Proximo = this.topo.Proximo;
            this.topo.Proximo = novo;
            return this.topo.Proximo;
        }

        public EleNumber Pop()
        {
            EleNumber aux = this.topo.Proximo;
            this.topo.Proximo = aux.Proximo;
            aux.Proximo = null;
            return aux;
        }

        public EleNumber Peek()
        {
            return this.topo.Proximo;
        }

        public bool PilhaVazia()
        {
            return (this.topo.Proximo == null);
        }

    }
}
