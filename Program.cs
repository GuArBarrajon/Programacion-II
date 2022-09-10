/*
 Alumno: Gustavo Barrajón
Turno Tarde
Ejercicio 1
Escribe un programa que tome 3 números enteros introducidos por el usuario mediante el teclado y determine cuántos de dichos 
números son diferentes, el promedio, la suma de todos, el producto del mayor por el menor y si el número restante es divisible 
por 3.
 */

static void Diferentes(int n1, int n2, int n3)
{
    if (n1 == n2 && n1 == n3)
    {
        Console.WriteLine("Los numeros son todos iguales");
    }
    else if (n1 == n2 ^ n1 == n3 ^ n2 == n3)
    {
        Console.WriteLine("Hay dos numeros iguales y uno distinto");
    }
    else
    {
        Console.WriteLine("Son 3 numeros disitntos");
    }
}

static int Suma(int n1, int n2, int n3)
{
    return n1 + n2 + n3;
}

static float Promedio(int n1, int n2, int n3)
{
    return (n1 + n2 + n3) / 3;    // No pude usar la función Suma (Una función estática no puede contener una referencia a "this" o "base")
}

static void ProdMayorMenoryRestante(int n1, int n2, int n3)
{
    int mayor = 0, menor = 0, restante = 0;

    if (n1 > n2 && n1 > n3)
    {
        mayor = n1;
    }
    else if (n2 > n3)
    {
        mayor = n2;
    }
    else
    {
        mayor = n3;
    }

    if (n1 < n2 && n1 < n3)
    {
        menor = n1;
    }
    else if (n2 < n3)
    {
        menor = n2;
    }
    else
    {
        menor = n3;
    }

    Console.WriteLine("El producto del menor (" + menor + ") por el mayor (" + mayor + ") es: " + menor * mayor);

    if ((n1 == mayor || n1 == menor) && (n2 == mayor || n2 == menor))
    {
        restante = n3;
    }
    else if (n1 == mayor || n1 == menor)
    {
        restante = n2;
    }
    else
    {
        restante = n1;
    }

    if (restante % 3 == 0)
    {
        Console.WriteLine("El numero restante (" + restante + ") es divisible por 3");
    }
    else
    {
        Console.WriteLine("El numero restante (" + restante + ") NO es divisible por 3");
    }
}

int numero1, numero2, numero3;
Console.Write("Ingrese el primer numero: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el tercer numero: ");
numero3 = Convert.ToInt32(Console.ReadLine());

Diferentes(numero1, numero2, numero3);
Console.WriteLine("El promedio de los numeros ingresados es: " + Promedio(numero1, numero2, numero3));
Console.WriteLine("La suma de los numeros ingresados es: " + Suma(numero1, numero2, numero3));
ProdMayorMenoryRestante(numero1, numero2, numero3);