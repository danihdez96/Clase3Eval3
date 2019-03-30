using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Suma
    {

        double n1, n2, resul;

        public double Resul
        {
            get { return resul; }
            set { resul = value; }
        }

        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }

       public Suma()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

       public double Calculos()
       {
           Resul=N1+N2;
           return Resul;
       }
    }
}
