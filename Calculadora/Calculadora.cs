float primeiroNumero;
float segundoNumero;
float adicao;
float subtracao;
float multiplicacao;
float divisao;

//Coleta valores do console
void ColetarValores()
{
	Console.Write("Digite o primeiro número: ");
	primeiroNumero = float.Parse(Console.ReadLine()!);
	Console.Write("Digite o segundo número: ");
	segundoNumero = float.Parse(Console.ReadLine()!);

	Adicao();
	Subtracao();
	Multiplicacao();
	Divisao();
	
	ExibeResultados();
}

//Operações
float Adicao()
{
	adicao = primeiroNumero + segundoNumero;
	return adicao;
}

float Subtracao()
{
	subtracao = primeiroNumero - segundoNumero;
	return subtracao;
}

float Multiplicacao()
{
	multiplicacao = primeiroNumero * segundoNumero;
	return multiplicacao;
}

float Divisao()
{
	divisao = primeiroNumero / segundoNumero;
	return divisao;
}

//Exibe resultados
void ExibeResultados()
{
	Console.WriteLine($"A soma {primeiroNumero} + {segundoNumero} é: {adicao}");
	Console.WriteLine($"A subtração {primeiroNumero} - {segundoNumero} é: {subtracao}");
	Console.WriteLine($"A multiplicação {primeiroNumero} * {segundoNumero} é: {multiplicacao}");
	Console.WriteLine($"A divisao {primeiroNumero} / {segundoNumero} é: {divisao}");
}

ColetarValores();
