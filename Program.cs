using TP_POO_Lijtenstein_Valen.Vehiculos;

Console.WriteLine("===== SISTEMA DE VEHÍCULOS =====");

List<Vehiculo> vehiculos = new List<Vehiculo>();

vehiculos.Add(new Auto("Toyota Corolla"));
vehiculos.Add(new Moto("Yamaha MT-03"));

foreach (Vehiculo vehiculo in vehiculos)
{
    vehiculo.MostrarInfo();

    Console.WriteLine("Acelerando...");
    vehiculo.Acelerar();
    vehiculo.MostrarInfo();

    Console.WriteLine("Frenando...");
    vehiculo.Frenar();
    vehiculo.MostrarInfo();

    Console.WriteLine("--------------------------------");
}