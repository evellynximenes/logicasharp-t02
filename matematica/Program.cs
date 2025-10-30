//declarando constantes
const int valor1 = 10;
const int valor2 = 5;

//Soma 
int soma = valor1 + valor2;
Console.WriteLine($"soma: {valor1} + {valor2} = {soma}");

//subtracção
int subtracao = valor1 - valor2;
Console.WriteLine($"subtração: {valor1} - {valor2} = {subtracao}");

//multiplicação
int multiplicacao = valor1 * valor2;
Console.WriteLine($"multiplicação: {valor1} * {valor2} = {multiplicacao}");

//divisão resultado
int divisao = valor1 / valor2;
Console.WriteLine($"divisão: {valor1} / {valor2} = {divisao}");

//resto da divisão
int restoDivisao = valor1 % valor2;
Console.WriteLine($"resto da divisão de: {valor1} / {valor2} = {restoDivisao}");


//potenciação(usando math para calcular a potancia)
double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"potenciação: {valor1} elevado a {valor2} = {potencia}");

/* comentario para mais de umaaaaa
 * a linha*/

//exemplo 1: sem parenteses
int resultado1 = 3 + 5 * 2;// multi tem prioridade
Console.WriteLine($"resultado 1 (sem parenteses): 3+5*2 = {resultado1}");

//exemplo 2: com parenteses
int resultado2 = (3 + 5) * 2; // parenteses alteram a ordem 
Console.WriteLine($"resultado2 (com parenteses): (3+5)*2 = {resultado2}");

//exemplo 3 ( sem parenteses)
int resultado3 = 8 / 4 + 3;
Console.WriteLine($"resultado 3: 8/4+3= {resultado3}");

//exemplo4 (com parenteses)
double resultado4 = 8.0 / (4 + 3);
Console.WriteLine($"resultado 4 :8/(4+3) = {resultado4}");
