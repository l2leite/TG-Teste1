using System;

namespace CartaoNS;

public class Cartao
{
	private string chave;
	private int numero;
	DateTime dataAtivacao = new DateTime();

	public string Chave { get { return chave; } set { chave = value; } }
	public int Numero { get { return numero; } set { numero = value; } }

	public Cartao() 
	{
		dataAtivacao = DateTime.Now;	
	}

	public override string ToString()
	{
		return numero.ToString();
	}
}
