using ClaseEstudiante;

Estudiante yoestudiante = new Estudiante("esteban",123521,25,44565474,"Buenos Aires","Argentina","Programacion",false);

if (yoestudiante.AsistenciaEnClase())
{
    Console.WriteLine("Asistio a clases");
}
else
{
    Console.WriteLine("No asistio a clases");
}
if (yoestudiante.NacimientoProcedenciaIgual())
{
    Console.WriteLine("son iguales");
}
else
{
    Console.WriteLine("no son el mismo lugar");
}
if (yoestudiante.EsMayorDeEdad())
{
    Console.WriteLine("es mayor de edad");
}
else
{
    Console.WriteLine("es menor de edad");
}