using _Senai7.Classes;
{
    static void Main(string[] args)
    {
        Triangulo t = new Triangulo();
		t.base = 6;
		t.altura = 4;
		t.CalcularArea();
		Console.WriteLine(t.area);
    }
}
