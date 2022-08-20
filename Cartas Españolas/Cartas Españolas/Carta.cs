using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Españolas.Cartas_Españolas
{

    public class Carta
    {

        private int valorCarta;
        private int paloCarta;
        private string[] palos = { "Oro", "Copa", "Palo", "Espada" };

        public string[] Palos
        {
            get { return palos; }
            set { palos = value; }
        }

        public int ValorCarta
        {
            get { return valorCarta; }
            set { valorCarta = value; }
        }


        public int PaloCarta
        {
            get { return paloCarta; }
            set { paloCarta = value; }
        }
        
        //revisar logica de este bloque
        public Carta(int valorCarta, int paloCarta)
        {

            ValorCarta = valorCarta;
            PaloCarta = paloCarta;
        }
      


        public void cartaActual()
        {
            Console.WriteLine(ValorCarta + " de " + Palos[PaloCarta]);
        }
        
    }

}