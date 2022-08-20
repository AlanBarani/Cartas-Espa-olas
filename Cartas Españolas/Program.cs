
using Cartas_Españolas.Cartas_Españolas;

Baraja baraja = new Baraja();

bool salir = false;

while (!salir)
{

    try
    {

        Console.WriteLine("1. Barajar");
        Console.WriteLine("2. Mostrar siguiente carta");
        Console.WriteLine("3. Mostrar cartas disponibles");
        Console.WriteLine("4. Dar cartas");
        Console.WriteLine("5. Mostrar cartas del monton");
        Console.WriteLine("6. Mostrar baraja");
        Console.WriteLine("7. Salir");



        Console.WriteLine("Elige una de las opciones\n");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has elegido Barajar\n");
                baraja.Barajar();
                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine("Has elegido Mostrar siguiente carta\n");
                baraja.SiguienteCarta();
                Console.WriteLine();
                break;

            case 3:
                Console.WriteLine("Has elegido Mostrar cartas disponibles\n");
                baraja.MostrarBaraja();
                Console.WriteLine();
                break;
            case 4:
                Console.WriteLine("Has elegido Dar cartas\n");
                Console.WriteLine("Cuantas cartas deseas dar?\n");
                int darCartas = Convert.ToInt32(Console.ReadLine());
                baraja.DarCartas(darCartas);
                Console.WriteLine();
                break;
            case 5:
                Console.WriteLine("Has elegido Mostrar cartas del monton\n");
                baraja.CartasMonton();
                Console.WriteLine();
                break;
            case 6:
                Console.WriteLine("Has elegido Mostrar baraja\n");
                baraja.MostrarBaraja();
                break;
                Console.WriteLine();
            case 7:
                Console.WriteLine("Has elegido Salir de la aplicacion\n");
                salir = true;
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Elige una opcion entre 1 y 4\n");
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.ReadLine();
