using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Españolas.Cartas_Españolas
{
    public class Baraja 
    {
        List<Carta> baraja = new List<Carta>();
  
        List<Carta> cartasMonton = new List<Carta>();
        Carta card;

        public Baraja()

        {
            int i, j;
            for (j = 0; j < 4; j++)
            {
                for (i = 0; i < 12; i++)
                {
                    card = new Carta(i + 1, j);

                    baraja.Add(card);
                }
            }
        }

        public void Barajar()
        {
            Random random = new Random();
            int cartaPosicion;

            for(int i= 0; i<48; i++){
                cartaPosicion = random.Next(0, 48);
                baraja.Insert(cartaPosicion, baraja[0]);
                baraja.Remove(baraja[0]);

            }
        }

        public void SiguienteCarta()
        {
            baraja[0].cartaActual();
            baraja.Remove(baraja[0]);
            cartasMonton.Add(baraja[0]);
            if (baraja.Count == 0)
            {
                Console.WriteLine("No quedan mas cartas");
            }
        }

        public void CartasDisponibles()
        {
            Console.WriteLine($"Hay {baraja.Count} cartas.");
        }

        public void DarCartas(int cantidad)
        {
            if (cantidad > baraja.Count)
            {
                Console.WriteLine("El numero de cartas pedidas es mayor a las disponibles");
            }
            else { 
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write((i + 1) + ". ");
                    baraja[i].cartaActual();
                }
            }
        }

        public void MostrarBaraja()
        {
            for (int i = 0; i < baraja.Count; i++)
            {
                Console.Write((i + 1) + ". ");
                baraja[i].cartaActual();
            }
            Console.WriteLine();
        }

        public void CartasMonton()
        {
            for (int i=0; i<cartasMonton.Count; i++)
            {
                cartasMonton[i].cartaActual();
            }
        }

    }
}
