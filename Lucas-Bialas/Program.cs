

using Lucas_Bialas;



Usuario Jorge = new Usuario(38, "jorge", "perez", "jorgeperez", "1234", "jgmail.com");

Console.WriteLine("Ingrese un nombre");
String nombre = Console.ReadLine();

Jorge.SetNombre(nombre);
Console.WriteLine(Jorge.GetNombre());