using System;
public class Programa
{
    public static void Main(string[] args)
    {
        Golondrina Gol1 = new Golondrina();
        Comida mijo = new Comida();
        mijo.SetCalorias(125);
               

        while(Gol1.GetEnergia() >= 0)
        {
            Console.Write("Ingrese cuántos gramos come la golondrina: ");
            Gol1.Comer(Convert.ToInt32(Console.ReadLine()), mijo);
            Gol1.EstaDebil();
            Gol1.EstaFeliz();
            Console.WriteLine($"Energía {Gol1.GetEnergia()}");
            if (Gol1.GetEnergia() >= 0)
            {
                Console.Write("Ingrese cuántos kilometros vuela la golondrina: ");
                Gol1.Volar(Convert.ToInt32(Console.ReadLine()));
                Gol1.EstaDebil();
                Gol1.EstaFeliz();
                Console.WriteLine($"Energía {Gol1.GetEnergia()}");
            }
        }

        Console.WriteLine("El pájaro está muerto");
    }
}