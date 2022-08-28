namespace medidas;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar
        //(imprimir os dados com quatro casas decimais):
        //a) a area do quadrado que tem lado A
        //b) a area do triangulo retangulo que base A e altura B
        //c) a area do trapezio que tem a bases A e B, e altura C

        double quadrado, triangulo, trapezio, A, B, C;

        Console.Write("Entre com a medida A: ");
        A = double.Parse(Console.ReadLine());

        Console.Write("Entre com a medida B: ");
        B = double.Parse(Console.ReadLine());

        Console.Write("Entre com a medida B: ");
        C = double.Parse(Console.ReadLine());

        quadrado = A * A;

        triangulo = A * B / 2;

        trapezio = (A + B) * C / 2;

        Console.Write("A area do quadrado é de = " + quadrado);

        Console.WriteLine();

        Console.Write("A area do triangulo é de = " + triangulo);

        Console.WriteLine();

        Console.WriteLine("A area do trapezio é de = " + trapezio);

    }
}