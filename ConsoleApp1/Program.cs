using ConceitosBasicos;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador();
result = soma.Soma(num1, num2);

Console.WriteLine($"A soma dos números {num1} e {num2} é {result}");
double metros = 1.5;
Console.WriteLine("A medida {0) corresponde a {1}",metros, Conversor.MetrosMilimetros(1.5));