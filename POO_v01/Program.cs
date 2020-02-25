using System;

namespace POO_v01
{
	class Vehiculo
	{
		string Marca;
		string Modelo;
		public void SetVehiculo(string x, string y)
		{
			this.Marca = x;
			this.Modelo = y;
		}
		public void VerVehiculo()
		{
			Console.WriteLine("El vehiculo es: {0} {1}", this.Marca, this.Modelo);
		}
	}
	public class MostrarVehiculo
	{
		public void Main()
		{
			Vehiculo obj1 = new Vehiculo();
			Vehiculo obj2 = new Vehiculo();
			Console.WriteLine("Ingrese la marca y luego el modelo, separados por enter");
			obj1.SetVehiculo(Console.ReadLine(), Console.ReadLine());
			obj1.VerVehiculo();
			Console.WriteLine("Ingrese la marca y luego el modelo, separados por enter");
			obj2.SetVehiculo(Console.ReadLine(), Console.ReadLine());
			obj2.VerVehiculo();
		}
	}
}
