// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine(
    "".PadLeft(20, '~') +
    "\nEscolha a Operação:\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n0 - Sair\n"
    + "".PadLeft(20, '~')
);

int operacao = Convert.ToInt32(Console.ReadLine());
Console.Write("Primeiro Número: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Segundo Número: ");
double n2 = Convert.ToDouble(Console.ReadLine());
double result = 0;

switch (operacao) {
    case 1:
        result = n1 + n2;
        break;
    case 2:
        result = n1 - n2;
        break;
    case 3:
        result = n1 * n2;
        break;
    case 4:
        result = n1 / n2;
        break;
    case 0:
        break;
}
if (n2 != 0)
{Console.Write(result);}
else 
{Console.Write("Operação Indefinida: Divisão Por Zero");}