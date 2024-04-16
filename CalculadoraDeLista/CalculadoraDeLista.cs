List<int> listaDeNumeros = new List<int>();
int tamanhoDaLista;
int adicao = 0;

//Coletando os valores
void ColetarValores()
{
	Console.Write("Digite a quantidade de números que sua lista terá: ");
	tamanhoDaLista = int.Parse(Console.ReadLine()!);
	Console.Write("Digite os números da sua lista: ");

	for (int i = 0; i < tamanhoDaLista; i++)
	{
		int numeroDaLista = int.Parse(Console.ReadLine()!);
		listaDeNumeros.Add(numeroDaLista);
	}

	Adicao();

	ExibirResultados();
}

//Operações
int Adicao()
{
	foreach (int numero in listaDeNumeros)
	{
		adicao += numero;
	}
	return adicao;
}

void ExibirResultados()
{
	Console.WriteLine($"A soma dos números da lista é: {adicao}");
}

ColetarValores();