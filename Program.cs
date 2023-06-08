// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
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

    int num5, num6;

    Console.WriteLine("Ingrese 2 numeros");
    Console.WriteLine("1er num: ");
    num5 = int.Parse(Console.ReadLine());
    Console.WriteLine("2do num: ");
    num6 = int.Parse(Console.ReadLine());

    if (num5 > num6)
    {
        Console.WriteLine("el 1er num ingresado "+num5+" es mayor al 2do num "+num6);
    } 
    
    if(num6 > num5){
        Console.WriteLine("el 2do num ingresado "+num6+" es mayor al 1er num "+num5);
    }

    if(num5 == num6){
        Console.WriteLine("Ambos numeros son iguales");
    }

    Console.WriteLine("Ingrese un texto: ");
    string cadena = Console.ReadLine();

    int cant = cadena.Length;
    Console.WriteLine("La longitud de la cadena es: "+cant);

    Console.WriteLine("Ingrese otro texto: ");
    string cadena2 = Console.ReadLine();

    string union = cadena + cadena2;

    Console.WriteLine("Cadenas concatenadas: "+union);

    Console.WriteLine("Ingrese 2 numeros!");

    Console.WriteLine("Ingrese un numero: ");
    int sum1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero: ");
    int sum2 = int.Parse(Console.ReadLine());

    int suma = sum1 + sum2;

    string cad1 = sum1.ToString();
    string cad2 = sum2.ToString();
    string resul = suma.ToString();

    Console.WriteLine("La suma de "+cad1+" Y "+cad2+" es: "+resul);

    foreach (char letra in cadena)
    {
        Console.WriteLine(letra);
    }

    Console.WriteLine("Ingrese un texto: ");
    string text = Console.ReadLine();

    Console.WriteLine("Ingrese una palabra para buscar en el texto: ");
    string palabra = Console.ReadLine();

    bool result = text.Contains(palabra);

    if(result){
        Console.WriteLine("Palabra encontrada!");
    }else{
        Console.WriteLine("No se encontro la palabra.");
    }

    text = text.ToUpper();

    Console.WriteLine("La cadena de texto en mayusculas: "+text);

    text = text.ToLower();

    Console.WriteLine("La cadena de texto en minusculas: "+text);

    string[] subtext = text.Split(',');

    foreach (string subtexts in subtext)
    {
        Console.WriteLine(subtexts);
    }

    Console.WriteLine("Ingrese una ecuacion suma: ");
    string ecuacion = Console.ReadLine();

    DataTable ecu = new DataTable();
    var salida = ecu.Compute(ecuacion, "");

    Console.WriteLine("El resultado de la suma es: " + salida);