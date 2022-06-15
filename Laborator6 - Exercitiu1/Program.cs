using System;

namespace Laborator6___Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Laborator 6 - Exercitii

            //Exercitiu 1

            //Un dulap are trei caracteristici: lungime, latime, inaltime.
            //Dulapul va avea o metoda care va calcula volumul acestuia. 
            //Folositi o clasa care va modela un dulap. 
            //Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
            //Cele trei campuri vor fi initializate cu ajutorul constructorului

            // - Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri
            // - Realiazti diagrama UML a clasei.
            // - Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul

            Dulap dulap = new Dulap(3, 10, 1);
            dulap.TiparesteVolumul();
        }
    }
}
