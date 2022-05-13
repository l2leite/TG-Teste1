using System;

namespace TelefoneNS;

public class Telefone
{
	long numero;
	int dDD;
	int dDI;
	string descricao;
	
	public long Numero { get { return numero; } set { numero = value; } }
	public int DDD { get { return dDD; } set { dDD = value; } }
	public string Descricao { get { return descricao; } set { descricao = value; } }
	public int DDI { get { return dDI; } set { dDI = value; } }
    public override string ToString()
    {
        return $"DDI: {DDI} \n" +
			$"DDD: {DDD} \n" +
			$"Telefone: {Numero} \n" +
			$"Descrição: {Descricao}";
    }
}
