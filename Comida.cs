using System;

class Comida
{
    private int calorias;

    public void SetCalorias(int cantidad)
    {
        if (cantidad >= 0)
                this.calorias = cantidad;
    }

    public int GetCalorias()
    {
        return this.calorias;
    }
}
