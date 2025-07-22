
do
{
    Console.Write("ingresa un numero entero: ");
    var num1 = int.Parse(Console.ReadLine());

    Console.Write("ingresa un numero entero: ");
    var num2 = int.Parse(Console.ReadLine());

    Console.Write("ingresa un numero entero: ");
    var num3 = int.Parse(Console.ReadLine());

    if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine($"el numero mayor es: {num1}");
        Console.WriteLine($"el numero del medio es: {num2}");
        Console.WriteLine($"el numero mayor es: {num3}");
    }


    else if (num2 < num3 && num2 < num1)
    {
        Console.WriteLine($"el numero mayor es: {num3}");
        Console.WriteLine($"el numero el del medio es: {num2}");
        Console.WriteLine($"el numero menor es: {num1}");

    }

    else if (num3 > num1 && num2 > num3)
    {
        Console.WriteLine($"El numero mayor es: {num3}");
        Console.WriteLine($"El numero del medio es: {num2}");
        Console.WriteLine($"El numero menor es: {num1}");
    }

    else if (num1 > num3 && num3 > num2)
    {
        Console.WriteLine($"El numero mayor es: {num3}");
        Console.WriteLine($"El numero del medio es: {num2}");
        Console.WriteLine($"El numero menor es: {num1}");
    }
} while (true);





