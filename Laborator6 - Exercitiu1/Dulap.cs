using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu1
{
    class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }
        public int GetVolumulDulapului()
        {
            return lungime * latime * inaltime;
        }
        public void TiparesteVolumul()
        {
            Console.WriteLine($"Dulapul are o lungime de {lungime}, o latime de {latime} si o inaltime de {inaltime}. Volumul dulapului este de: {GetVolumulDulapului()} ");
        }
    }
}
