using System;

namespace PessoaFisicaNS;

public class Pessoa
{
	private string? nome;
	private long cPF;
	DateTime dataNascimento = new DateTime();
	private string? estadoCivil;
	private string? naturalidade;
	private string? nacionalidade;
	private string? email;
	private string? sexo;

	public string? Nome { get; set; }

	public long CPF { get; set; }

	public string? Nacionalidade { get; set; }

	public string? EstadoCivil { get; set; }

	public string? Email { get; set; }

	public string? Sexo { get; set; }

    public override string ToString()
    {
		char[] cCPF;
		cCPF = CPF.ToString().ToCharArray();
		string sCPF = $"{cCPF[0]}{cCPF[1]}{cCPF[2]}.{cCPF[3]}{cCPF[4]}{cCPF[5]}." + 
			$"{cCPF[6]}{cCPF[7]}{cCPF[8]}-{cCPF[9]}{cCPF[10]}";
		
		return $"Nome: {Nome} \n" +           
			$"CPF: {sCPF} \n" +
			$"Nacionalidade: {Nacionalidade} \n" +
			$"Estado Civil: {EstadoCivil} \n" +
			$"E-mail: {Email}";
    }
	
}
