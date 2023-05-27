// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int c;
bool dato = false;

while (!dato)
{
    Console.WriteLine("Ingrese un número: ");
    string tipo = Console.ReadLine();

    dato = int.TryParse(tipo, out c);

    if (dato)
    {
        Console.WriteLine("El número ingresado es: " + c);
        if(c > 0){
            Console.WriteLine("Inversion!!");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un número entero válido.");
    }
}
