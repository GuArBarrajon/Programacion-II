using System;

class Golondrina
{
    private int energia = 0;
    public int GetEnergia()
    {
        return this.energia;
    }
    public void Comer(int cantidad, Comida x)
    {
        this.energia += x.GetCalorias() * cantidad;
    }
    public void Volar(int Kilometros)
    {
        if (this.energia >= Kilometros + 10)
        {
            this.energia -= (Kilometros + 10);
        }
        else
        {
            Console.WriteLine("No tiene suficiente energía");
        }

    }
    public void EstaDebil()
    {
        if (this.energia <= 500)
        {
            Console.WriteLine("El pájaro está débil, necesita comer");
        }
    }
    public void EstaFeliz()
    {
        if (this.energia >= 500)
        {
            Console.WriteLine("El pájaro está feliz");
        }
    }
}