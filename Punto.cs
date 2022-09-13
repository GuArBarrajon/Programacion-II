using System;
using System.Collections.Generic;
using System;
class Punto
    {
    private double x;
    private double y;
    
    public double GetX()
        { return x; }

    public void SetX(double valor)
        { this.x = valor; }

    public double GetY()
    { return y; }

    public void SetY(double valor)
    { this.y = valor; }

    public void IgualA(Punto OtroPunto)
    {
        if(this.x == OtroPunto.GetX() && this.y == OtroPunto.GetY())
        {
            Console.WriteLine("Son iguales");
        }
        else
        {
            Console.WriteLine("Son disitintos");
        }
    }
    public Punto SumaPuntos(Punto OtroPunto)
    {
        Punto Resultado = new Punto();
        Resultado.SetX (this.x + OtroPunto.GetX());
        Resultado.SetY (this.y + OtroPunto.GetY());
        return Resultado;
    }
    public Punto RestaPuntos(Punto OtroPunto)
    {
        Punto Resultado = new Punto();
        Resultado.SetX(this.x - OtroPunto.GetX());
        Resultado.SetY(this.y - OtroPunto.GetY());
        return Resultado;
    }
}

