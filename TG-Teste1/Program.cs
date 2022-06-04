using PessoaFisicaNS;
using TelefoneNS;
using DocumentoNS;
using EnderecoNS;
using PessoaJuridicaNS;
using SubstanciaNS;
using ClienteNS;
using MySqlClienteNS;







/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime dataAgora = DateTime.Now;
Console.WriteLine(dataAgora.ToString());
Console.WriteLine(DateTime.Now.ToString());
Console.WriteLine(dataAgora.Day);
//dataAgora = DataBR.DataBR.DataTime();
DataBR.DataBR dataNow = new DataBR.DataBR();
dataNow.Data = dataAgora;
Console.WriteLine(dataAgora);
Console.WriteLine(dataNow);
Console.WriteLine(dataNow.Data);
Console.WriteLine(dataNow.ToString());
Console.WriteLine(dataNow.Data.Day);
*/
/*Cliente cliente = new Cliente();
cliente.cliente.CPF = 31498924816;
cliente.cliente.Nome = "Dranoel";
cliente.cliente.Nacionalidade = "Brasileiro";
cliente.Senha = "13201320";
Console.WriteLine(cliente.ToString());
Console.WriteLine(cliente.cliente.CPF.ToString());
Console.WriteLine(cliente.cliente.Nome);


Telefone celular = new Telefone();
celular.Numero = 999580775;
celular.DDI = 55;
celular.DDD = 11;
celular.Descricao = "Celular";
Console.WriteLine(celular);
Console.WriteLine(celular.ToString());

Documento doc = new Documento();
doc.Numero = 31498924816;
doc.Tipo = "CPF";
Console.WriteLine(doc);

Endereco end1 = new Endereco();
end1.Numero = 51;
end1.Logadouro = "Rua Edgard Monteiro Lobato";
end1.Cidade = "Taubaté";
end1.Bairro = "Chácara do Visconde";
end1.Complemento = "Casa4";
end1.Estado = "São Paulo";
end1.CodigoPostal = "12050-770";
end1.Pais = "Brasil";
Console.WriteLine(end1);

PessoaJuridica empresa = new PessoaJuridica();
empresa.RazaoSocial = "Dynamic Imports LTDA-ME";
empresa.CNPJ = 20473257000178;
Console.WriteLine(empresa);
Console.WriteLine(empresa.SCNPJ(empresa.CNPJ));

Substancia acidoOleico = new Substancia();
acidoOleico.Nome = "Ácido Oleíco";
acidoOleico.NomeTecnico = "Ácido 12-Octadecenóico";
acidoOleico.Sinonimos = "Ácido Graxo Oleíco, Ácido OctaDec 12-enóico.";
acidoOleico.PesoMolecular = 282.4701f;
Console.WriteLine(acidoOleico);


Cliente clientes = new Cliente();
clientes.cliente.Nome = "Leonard Giordanni Batista Leite";
clientes.cliente.CPF = 31498924844;
clientes.cliente.Nacionalidade = "Brasileiro";
clientes.cliente.EstadoCivil = "Casado";
clientes.fone.DDD = 11;
clientes.fone.Numero = 999580775;
clientes.dataCadastro = DateTime.Now;
clientes.Saldo = 1254.56;
clientes.Status = "Ativo";
clientes.Login = "leo.giordani05";
clientes.Senha = clientes.Login.GetHashCode().ToString();
Console.WriteLine(clientes);

MySqlCliente cli = new MySqlCliente(clientes);
Console.WriteLine(cli.Adicionar(clientes));
Console.WriteLine(cli.Alterar(31498924839, cliente));
Console.WriteLine(cli.Excluir(31498924838));*/



//Console.WriteLine(dataNascimento.Date.ToString());