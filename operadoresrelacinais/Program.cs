int a = 10;
int b = 05;

//operadores relacionais

bool maiorQue = a > b;
bool menorQue = a < b;
bool igual = a == b;
bool diferente = a != b;
bool maiorOuIgual = a >= b;
bool menorOuIgual = a <= b;


//exibindo resultados dos operadores relacionais
Console.WriteLine("\nOperadores Relacionais:");
Console.WriteLine($"\n {a} > {b}: {maiorQue}");
Console.WriteLine($"\n {a} < {b}: {menorQue}");
Console.WriteLine($"\n {a} == {b}: {igual}");
Console.WriteLine($"\n{a} != {b}: {diferente}");
Console.WriteLine($"\n{a} >= {b}: {maiorOuIgual}");
Console.WriteLine($"\n{a} <= {b}: {menorOuIgual}");