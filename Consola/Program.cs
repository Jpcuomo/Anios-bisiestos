using ClassLibrary1;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = AnioBisiesto.IngresarAnio();
            int final = AnioBisiesto.IngresarAnio();
            while (true)
            {
                if (inicio < final)
                {
                    AnioBisiesto.CalcularAnioBisiesto(inicio, final);
                    break;
                }
                else
                {
                    Console.WriteLine("En año de inico debe ser menor al de finalización");
                    break;
                }
            }
        }
    }
}