class Moto : Vehiculos
{
    protected string motor;
    protected string objetosSeguridad;

    public Moto() { }

    public Moto(int ruedas, double peso, double dimensiones, string color, string motor, string objetosSeguridad) : base (ruedas, peso, dimensiones, color)
    {
        this.motor = motor;
        this.objetosSeguridad = objetosSeguridad;
        Console.WriteLine("Se creó la moto");
    }

    public new void Acelerar()
    {
        Console.WriteLine("Estoy acelerando como una moto");
    }

    public new void Willy()
    {
        Console.WriteLine("Estoy haciendo Willy");
    }
}