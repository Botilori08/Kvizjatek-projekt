using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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

        public List <string> randomValasz()
        {
            Random rand = new Random();
            List<string> valaszok = new List<string>();

            valaszok.Add(this.valasz1);
            valaszok.Add(this.valasz2);
            valaszok.Add(this.valasz3);
            valaszok.Add(this.valasz4);

            int n = valaszok.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string value = valaszok[k];
                valaszok[k] = valaszok[n];
                valaszok[n] = value;
            }

            return valaszok;


        }

        public bool helyesEavalasz(string tipp)
        {

            return tipp == this.helyesvalasz;
        }



    }
}
