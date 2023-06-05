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

//calculadora.


    int tipo2;
    int num1; 
    int num2;
    int num3;
    float resultado;
    resultado = 0;

    Console.WriteLine("Ingrese 2 numeros!");

    Console.WriteLine("El primer numero: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("El segundo numero: ");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Desea hacer una suma(1), producto(2), resta(3), division(4) ?");
    tipo2 = int.Parse(Console.ReadLine());

    switch (tipo2)
    {
        case 1: resultado = num1 + num2;
        break;
        case 2: resultado = num1 * num2;
        break;
        case 3: resultado = num1 - num2;
        break;
        case 4: resultado = num1 / num2;
        break;
    }

    Console.WriteLine("Resultado: "+resultado);

    Console.WriteLine("Ingrese un numero: ");
    num3 = int.Parse(Console.ReadLine());

    int valorAbs;

    valorAbs = Math.Abs(num3);
    Console.WriteLine("El valor absoluto de "+num3+" es: "+valorAbs);

    int cuadrado = num3 * num3;

    Console.WriteLine("El cuadrado de "+num3+" es: "+cuadrado);

    double Raiz = Math.Sqrt(num3);

    Console.WriteLine("La raiz cuadrada de "+num3+" es: "+Raiz);

    double seno = Math.PI * num3 / 180;
    seno = Math.Sin(seno);

    Console.WriteLine("El seno de "+num3+" es: "+seno);

    double coseno = Math.PI * num3 / 180;
    coseno = Math.Cos(coseno);

    Console.WriteLine("El coseno de "+num3+" es: "+coseno);

    float num4 = 13.768f;
    int entera = (int)Math.Floor(num4);
    Console.WriteLine("La parte entera de "+num4+" es: "+entera);