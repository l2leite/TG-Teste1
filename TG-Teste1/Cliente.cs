using System;
using PessoaFisicaNS;
using TelefoneNS;
using EnderecoNS;

namespace ClienteNS;

public class Cliente
{
    public Pessoa cliente = new Pessoa();
    public Telefone fone = new Telefone();
    public Endereco endereco = new Endereco();
    string login;
    string senha;
    public DateTime dataCadastro = new DateTime();
    double saldo;
    string status;

    public Cliente()
    {
        dataCadastro = DateTime.Now;
    }

    public string Login { get { return login; } set { login = value; } }
    public string Senha { get { return senha; } set { senha = value; } }
    public double Saldo { get { return saldo; } set { saldo = value; } }
    public string Status { get { return status; } set { status = value; } }
    public override string ToString() 
    {
        return $"Nome: {cliente}\n" +
            $"Telefone: ({fone.DDD}) {fone.Numero}\n" +
            $"Login: {Login}\n" +
            $"Saldo: R$ {Saldo, 0:0.00}";
    }

}
