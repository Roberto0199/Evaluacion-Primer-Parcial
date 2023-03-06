int Num = 0;
int sumaPares = 0;
bool Valido = false;
while (!Valido)

{
    Console.Write("Ingrese un número entero positivo mayor que cero: ");
    string Salida = Console.ReadLine();
    Valido = int.TryParse(Salida, out Num) && Num > 0;
    if (!Valido)
    {
        Console.WriteLine("El número ingresado no es válido. Intente de nuevo.");
    }
}


for (int i = 2; i <= Num; i += 2)
{
    sumaPares += i;
}

Console.WriteLine("Los números enteros positivos menores o iguales que N que son divisibles entre 2 y 3 son:");
for (int i = 1; i <= Num; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

Console.WriteLine("Los números enteros positivos menores o iguales que N que son divisibles entre 3 y 5 son:");
for (int i = 1; i <= Num; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

Console.WriteLine("La secuencia de números enteros positivos que comienzan en N y se decrementan en 1 hasta que se alcance un valor menor que 1 es:");
while (Num >= 1)
{
    Console.Write(Num + " ");
    Num--;
}
Console.WriteLine();

Console.WriteLine("El valor de la variable 'sumaPares' es: " + sumaPares);
