class Vehiculos
{
    protected int cantRuedas;
    protected double peso;
    protected double dimensiones;
    protected string color;

    public Vehiculos() { }
    public Vehiculos(int cantRuedas, double peso, double dimensiones, string color)
    {
        this.cantRuedas = cantRuedas;
        this.peso = peso;
        this.dimensiones = dimensiones;
        this.color = color;
        Console.WriteLine("Vehículo creado");
    }
    
    public void Mostrar()
    {
        Console.WriteLine("Cantidad de ruedas: {0}, Peso: {1}, Dimensiones: {2}, Color: {3}", this.cantRuedas, this.peso, this.dimensiones, this.color);
    }

    public void Acelerar()
    {
        Console.WriteLine("Estoy acelerando");
    }
    public void Frenar()
    {
        Console.WriteLine("Estoy frenando");
    }

    public void Doblar()
    {
        Console.WriteLine("Estoy doblando");
    }
}