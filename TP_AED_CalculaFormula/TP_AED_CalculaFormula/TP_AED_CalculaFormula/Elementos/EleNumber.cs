using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula.Elementos
{
    public class EleNumber
    {

        private double dado;

        private EleNumber proximo;

        public double Dado { get => dado; set => dado = value; }
        public EleNumber Proximo { get => proximo; set => proximo = value; }

        public EleNumber(string dado)
        {
            this.dado = double.Parse(dado);
        }

        public EleNumber(double dado)
        {
            this.dado = dado;
        }

        public EleNumber()
        {

        }

    }
}
