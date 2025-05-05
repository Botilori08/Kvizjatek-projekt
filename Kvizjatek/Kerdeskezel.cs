using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Kvizjatek
{
    internal class Kerdeskezel
    {
        public string kerdes;
        public string valasz1;
        public string valasz2;
        public string valasz3;
        public string valasz4;
        public string helyesvalasz;
        public int penz;

        public Kerdeskezel(string sor)
        {
            string[] vag = sor.Split(';');
            this.kerdes = vag[0];
            this.valasz1 = vag[1];
            this.valasz2 = vag[2];
            this.valasz3 = vag[3];
            this.valasz4 = vag[4];
            this.helyesvalasz = vag[5];
            this.penz = Convert.ToInt32(vag[6]);
        }
    }
}
