//variaveis 
char letra = 'a';
string nome = "joão";
float temperatura = 36.5f;
double salario = 12345.67;
bool estaChovendo = true;

//alterando as variaveis 
letra = 'b';
nome = "MARIA";
temperatura = 37.0f;
salario = 15000.50;
estaChovendo = false;


//constantes
const char simbolo = '$';
const string saudacao = "Bem vindo ao c#!";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehVerdade = false;
const int numero = 14;

// exibindo os valores originais por interpolação
Console.WriteLine("valores originais:");
Console.WriteLine($"letra: {letra}");
Console.WriteLine($"nome: {nome}");
Console.WriteLine($"temperatura: {temperatura}");
Console.WriteLine($"salário: {salario}");
Console.WriteLine($"está Chovendo? {estaChovendo}");


//exibindo os valores originais por concatenação
Console.WriteLine("\nconstantes:");
Console.WriteLine("simbolo:" + simbolo);
Console.WriteLine("Saudação:" + saudacao);
Console.WriteLine("valor e pi:" + pi);
Console.WriteLine("altura:" + altura);
Console.WriteLine("É Verdade?" + ehVerdade);
Console.WriteLine("número:" + numero);

