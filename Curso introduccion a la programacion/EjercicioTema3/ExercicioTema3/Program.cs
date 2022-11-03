namespace EjecicioTema3
{
    class Ejecicio
    {
        //Parte uno
        static void Main(string[] args)
        {
            int primer = 5;
            int segundo = 2;
            int tercero = 9;

            Suma(primer, segundo, tercero);

            //Suma ejercicio parte dos
            coche miCoche = new coche();
            miCoche.SumaPuertas();
            Console.WriteLine(miCoche.puertas);
            Console.Read();
            //
        }

        private static int Suma(int a, int b, int c)
        {
            return (a + b + c);
        }

        //
        //Parte dos
        class coche
        {
            public int puertas = 0;

            public void SumaPuertas()
            {
                puertas += 1;
            }
        }
    }

    
}

