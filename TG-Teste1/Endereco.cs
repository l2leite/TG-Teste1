using System;

namespace EnderecoNS;

public class Endereco
{
	string logadouro;
	int numero;
	string complemento;
	string bairro;
	string cidade;
	string estado;
	string codigoPostal;
	string pais;

	public string Logadouro { get; set; }
	public int Numero { get; set; }
	public string Complemento { get; set; }
	public string Bairro { get; set; }
	public string Cidade { get; set; }
	public string Estado { get; set; }
	public string CodigoPostal { get; set; }
	public string Pais { get; set; }
	public override string ToString()
    {
		return $"Endereço: {Logadouro}, {Numero} - {Complemento} \n" +
            $"{Bairro} - {Cidade} / {Estado} - {Pais} \n" +
            $"CEP: {CodigoPostal}";
    }


}
