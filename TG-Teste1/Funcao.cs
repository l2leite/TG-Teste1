using System;

namespace FuncaoNS;

public class Funcao
{
	string permissoes;
	string descricao;

	public string Permissoes { get; set; }
	public string Descricao { get; set; }

	public Funcao()
	{
		permissoes = "Z0";
		descricao = "Nenhum acesso permitido.";
	}
}
