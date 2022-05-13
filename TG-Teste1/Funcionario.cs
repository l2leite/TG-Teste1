using System;
using PessoaFisicaNS;
using TelefoneNS;
using EnderecoNS;
using FuncaoNS;

namespace FuncionarioNS;

public class Funcionario
{
	Pessoa funcionario = new Pessoa();
	Telefone fone = new Telefone();
	Endereco endereco = new Endereco();
	string usuario;
	string senha;
	DateTime dataCadastro = new DateTime();
	Funcao funcao = new Funcao();

	public string Senha { get; set; }
	public Funcionario()
	{
		dataCadastro = DateTime.Now;
	}
}
