using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula
{
    public class ElemFormula
    {

        private string formula;

        private ElemFormula proximo;

        public string Formula
        {
            get
            {
                return formula;
            }

            set
            {
                formula = value;
            }
        }

        public ElemFormula Proximo
        {
            get
            {
                return proximo;
            }

            set
            {
                proximo = value;
            }
        }


        //  public string Formula { get => formula; set => formula = value; }

        //   public ElemFormula Proximo { get => proximo; set => proximo = value; }

        public ElemFormula(string formula)
        {
            this.formula = formula;
        }

        public ElemFormula()
        {

        }

    }

}
