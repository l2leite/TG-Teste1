using System;

namespace SubstanciaNS;

public class Substancia
{
	string nome;
	string nomeTecnico;
	string sinonimos;
	float pesoMolecular;
	float porcentagem;

	public string Nome { get; set; }
	public string NomeTecnico { get; set; }
	public string Sinonimos { get; set; }
	public float PesoMolecular { get; set; }
	public float Porcentagem { get; set; }

	public override string ToString()
	{
		return $"Nome: {Nome}.\n" +
            $"Nome Técnico: {NomeTecnico}.\n" +
            $"Sinônimos: {Sinonimos}.\n" +
            $"Peso Molecular: {PesoMolecular, 00:00.000} g/mol.";
	}
}
