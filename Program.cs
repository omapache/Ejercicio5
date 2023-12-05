/* Console.WriteLine("cuantas ejercicios resolvio sam ?");
int cantidadSam = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("cuantas ejercicios resolvio Kelly ?");
int cantidadKelly = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("cuanta diferencia tienen?");
int diferencia = Convert.ToInt32(Console.ReadLine());

int contador = 0;

int DailySam  = diferencia;
int DailyKelly = 0;

while (DailySam >= DailyKelly || contador == 100)
{
    contador += 1;
    DailySam += cantidadSam;
    DailyKelly += cantidadKelly;


}
if (contador <= 100)
{
    Console.WriteLine(contador);
}
else
{
    Console.WriteLine(-1);

} */

Console.WriteLine("inserte la longitud que tendra el array");
int longitud = Convert.ToInt32(Console.ReadLine());
 
            //Genera un numero entre 10 y 100 (101 no se incluye)

int[] lista = new int[longitud];

for (int i = 0; i < longitud; i++)
{
    Random r = new Random ();
    lista[i] = r.Next (0,1000000000);
Console.WriteLine(lista[i]);
}
