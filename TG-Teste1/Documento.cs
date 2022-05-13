using System;

namespace DocumentoNS;

public class Documento
{
	string tipo;
	long numero;

	public string Tipo { get; set; }
	public long Numero { get; set; }
	public override string ToString() 
	{
		return $"Documento: {Tipo} - Número: {Numero}";
	}
}
