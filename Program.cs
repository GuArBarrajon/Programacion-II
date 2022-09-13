Punto P1 = new Punto();
Punto P2 = new Punto();

P1.SetX(51);
P1.SetY(63);
P2.SetX(102);
P2.SetY(83);

P1.IgualA(P2);

Punto R = P1.SumaPuntos(P2);     
Console.WriteLine("La suma de los puntos ingresados es " + R.GetX() + ", " + R.GetY());
Punto R2= P1.RestaPuntos(P2);
Console.WriteLine("La resa de los puntos ingresados es: " + R2.GetX() + ", " + R2.GetY());