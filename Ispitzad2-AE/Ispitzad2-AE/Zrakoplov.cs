using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispitzad2_AE
{
    class Zrakoplov
    {
        private string Naziv;
        private double SnagaMotora;
        private int DosegLeta;

        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            Naziv = naziv;
            SnagaMotora = snagaMotora;
            DosegLeta = dosegLeta;
        }
    }
}
