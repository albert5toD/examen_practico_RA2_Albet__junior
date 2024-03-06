// See https://aka.ms/new-console-template for more information
Console.WriteLine("chuky");
Console.WriteLine();

empleados empleados = new empleados();

empleados.id = 101;
empleados.name = "Albert junior";
empleados.cargo = "limpiador";
empleados.sueldo = 4587.32;

empleados.imprimirdatos();
class empleados
{
    public int id;
    public string name;
    public string cargo;
    public double sueldo;

    public void imprimirdatos()
    {
        Console.WriteLine($"{name} con el ID {id} ocupa el puesto de {cargo}" +
            $"y cobra el {sueldo}");
    }
}
