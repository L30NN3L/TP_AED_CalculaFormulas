using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_AED_CalculaFormula
{
    public class ElemSimbolo
    {

        private string simbolo;

        private ElemSimbolo proximo;

        public string Simbolo
        {
            get
            {
                return simbolo;
            }

            set
            {
                simbolo = value;
            }
        }

        public ElemSimbolo Proximo
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


        //     public string Simbolo { get => simbolo; set => simbolo = value; }

        //     public ElemSimbolo Proximo { get => proximo; set => proximo = value; }

        public ElemSimbolo()
        {

        }

        public ElemSimbolo(string simbolo)
        {
            this.Simbolo = simbolo;
        }

    }
}
