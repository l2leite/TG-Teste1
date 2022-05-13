using System;

namespace OperacaoNS;

public class Operacao
{
	double valorUnitario;
	double valorTotal;
	string movimentacao;
	string descricao;
	double quantidade;
	DateTime dataOperacao = new DateTime();

	public double ValorUnitario { get; set; }
	public double ValorTotal { get; set; }
	public double Quantidade { get; set; }
	public string Movimentacao { get; set; }
	public string Descricao { get; set; }
	
	public override string ToString()
	{
		return $"";
	}
}
