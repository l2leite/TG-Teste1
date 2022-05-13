using System;
using SubstanciaNS;

namespace MisturaNS;

public class Mistura
{
	string nome;
	Substancia[] subst;
	float[] porcentagem;
	float pesoMM;

	public string Nome { get { return nome; } set { nome = value; } }
	public Substancia[] Subst { get { return subst; } set { subst = value; } }
	public float[] Porcentagem { get { return porcentagem; } set { porcentagem = value; } }
	public float PesoMM { get { return pesoMM; } set { pesoMM = value;} }
    public override string ToString()
    {
		return $"Nome: {nome}\n";            
    }
}
