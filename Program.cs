

Console.WriteLine("Adivina el numero");
Random rnd = new Random();
int num = rnd.Next(1, 11);
int entrada = 0;
Console.WriteLine("Ingresa el numero entero que creas correcto");
do
{
    entrada = int.Parse(Console.ReadLine());
    if (entrada == num)
        Console.WriteLine(num + " es el numero correcto");
    else
    {
        if (entrada > num)
            Console.WriteLine(entrada + " es mayor al numero deseado, intenta de nuevo");
        else if (entrada < num)
            Console.WriteLine(entrada + " es menor al numero deseado, intenta de nuevo");
        else
            Console.WriteLine("Ingrese un numero valido");
    }
} while (entrada != num);
Console.WriteLine("El numero generado es " + num);
Console.ReadKey();
