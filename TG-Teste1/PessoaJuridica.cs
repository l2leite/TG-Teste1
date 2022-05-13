using System;

namespace PessoaJuridicaNS;
public class PessoaJuridica
{
	string razaoSocial;
	long cNPJ;
	long iE;
	long iM;
	DateTime dataAbertura = new DateTime();
	string porte;

	public string RazaoSocial { get { return razaoSocial; } set { razaoSocial = value; } }
	public long CNPJ 
	{ 
		get 
		{ 
			return cNPJ; 
		} 
		set { cNPJ = value; }
	}
	public string SCNPJ(long cnpj) 
	{
		char[] scnpj;
		scnpj = cnpj.ToString().ToCharArray();
		return $"{scnpj[0]}{scnpj[1]}.{scnpj[2]}{scnpj[3]}{scnpj[4]}.{scnpj[5]}{scnpj[6]}{scnpj[7]}" +
            $"/{scnpj[8]}{scnpj[9]}{scnpj[10]}{scnpj[11]}-{scnpj[12]}{scnpj[13]}";
	}
	public long IE { get { return iE; } set { iE = value; } }
	public long IM { get { return iM; } set { iM = value; } }
	public string Porte { get { return porte; } set { porte = value; } }
    public override string ToString()
    {
        return $"Razão Social: {razaoSocial}\n" +
            $"CNPJ: {SCNPJ(cNPJ)}";
    }

}
