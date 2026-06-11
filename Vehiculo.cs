public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int VelocidadActual { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        VelocidadActual = 0;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Vehículo: " + Marca + " " + Modelo + "n/" +
        "Velocidad actual: " + VelocidadActual + " km/h");
    }

    public abstract void Acelerar();

    public abstract void Frenar();
}