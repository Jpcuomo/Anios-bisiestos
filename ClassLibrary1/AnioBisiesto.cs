namespace ClassLibrary1
{
    public class AnioBisiesto
    {
        private static int _anioInicio { get; set; }
        private static int _anioFin { get; set; }


        /// <summary>
        /// Informa qué años en el rango ingresado son bisiestos
        /// </summary>
        /// <param name="inicio">Año de inicio</param>
        /// <param name="fin">Año de finalización</param>
        public static void CalcularAnioBisiesto(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++) 
            { 
                if(i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine($"{i} es bisiesto");
                }
                //Console.WriteLine("No es bisiesto");
            }
        }

        /// <summary>
        /// Pide al usuario un año y valida que sea numérico
        /// </summary>
        /// <returns>Entero</returns>
        public static int IngresarAnio()
        {
            int anio;
            while (true)
            {
                Console.WriteLine("Ingrese un año: ");
                if (int.TryParse(Console.ReadLine(), out anio))
                {
                    if (anio > 0)
                    {
                        return anio;
                    }
                   
                    Console.WriteLine("El año debe ser mayor que cero.");
                }
                Console.WriteLine("Valor incorrecto. Introduzca un año válido.");
            }
        }

    }
}