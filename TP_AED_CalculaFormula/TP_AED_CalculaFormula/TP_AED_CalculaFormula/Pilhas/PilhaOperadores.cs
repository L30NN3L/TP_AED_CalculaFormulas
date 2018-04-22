using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_AED_CalculaFormula.Elementos;

namespace TP_AED_CalculaFormula
{
    class PilhaOperadores
    {

        private ElementOp topo;

        public PilhaOperadores()
        {
            this.topo = new ElementOp();
        }

        public ElementOp Push(ElementOp novo)
        {

            novo.Proximo = this.topo.Proximo;
            this.topo.Proximo = novo;
            return (ElementOp)this.topo.Proximo;
        }

        public ElementOp Pop()
        {

            ElementOp aux = (ElementOp)this.topo.Proximo;
            this.topo.Proximo = aux.Proximo;
            aux.Proximo = null;
            return aux;

        }

        public ElementOp Peek()
        {

            return (ElementOp)this.topo.Proximo;

        }

    }
}
