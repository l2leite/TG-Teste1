using System;
using MySql.Data.MySqlClient;
using ClienteNS;

namespace MySqlClienteNS;

public class MySqlCliente
{
	Cliente cliente = new Cliente();

	// Informações do banco de dados
	string server = "localhost";
	string user = "root";
	string password = "13201320";
	string database = "db_tg_teste01";

	public MySqlCliente(Cliente cli)
    {
		Cliente cliente = cli;
    }

	public MySqlConnection Conectar()
	{
		// Endereço do banco de dados
		string chainconection = " server=" + server + ";user=" + user + ";pwd=" +
				password + ";database=" + database + ";SslMode=none;";
		MySqlConnection myCon = new MySqlConnection(chainconection);
		return myCon;
	}

	public string Adicionar(Cliente cli) 
	{
		// Tentar Conecção
		cliente = cli;
		MySqlConnection myCon = Conectar();
		myCon.Open();
		try
		{

			MySqlCommand cmd = myCon.CreateCommand();

			// Tentar inserção de dados em  tbl_Pessoa
			try
            {
				// Declaração (Statement) do comando  
				cmd.CommandText = "INSERT INTO TBL_PESSOA(PES_NOME, PES_CPF, PES_RG, " +
                    "PES_DATANASCIMENTO, PES_EMAIL, PES_NASCIONALIDADE) VALUES(@nome,@cpf," +
                    "@rg,@datanascimento,@email,@nacionalidade)";
				
				//Inserçção dos Valores
				cmd.Parameters.AddWithValue("@nome", this.cliente.cliente.Nome);
				cmd.Parameters.AddWithValue("@cpf", cliente.cliente.CPF);
				cmd.Parameters.AddWithValue("@rg", "43770391");
				cmd.Parameters.AddWithValue("@datanascimento", DateTime.Now.Date);
				cmd.Parameters.AddWithValue("@email", cliente.cliente.Email);
				cmd.Parameters.AddWithValue("@nacionalidade", cliente.cliente.Nacionalidade);

				// Preparação do Comando
				cmd.Prepare();

				// Execução do comando
				cmd.ExecuteNonQuery();

				Console.WriteLine("Primeira inserção feita com sucesso.");
			}
			catch (MySqlException err)
            {
				if (err.Code == 0)
				{
					myCon.Close();
					return "CPF Cadastrado" + err.Message + "\nCódigo do erro = " + err.Code.ToString();
				}
				else
				{
					myCon.Close();
					return "Erro na inserção da tabela Pessoa!\n" + err.Message + err.Code.ToString();
				}
            }
			
			//Tentar inserção de dados em tbl_Cliente
			try
			{
				// Obter o código pes_codigo da pessoa cadastrada
				int pes_codigo;

				// Declaração (Statement) do comando  
				cmd.CommandText = "INSERT INTO TBL_CLIENTE(CLI_CODIGOPES, CLI_LOGIN, CLI_SENHA, " +
                    "CLI_DATAHORACADASTRO, CLI_STATUS, CLI_SALDO) VALUES(" +
                    "(SELECT PES_CODIGO FROM TBL_PESSOA WHERE(PES_CPF=@cpf)),@login,@senha," +
                    "@datahoracadastro,@status,@saldo);";

				//Inserçção dos Valores
				//cmd.Parameters.AddWithValue("@cpf01", cliente.cliente.CPF);
				cmd.Parameters.AddWithValue("@login", cliente.Login);
				cmd.Parameters.AddWithValue("@senha", cliente.Senha);
				cmd.Parameters.AddWithValue("@datahoracadastro", DateTime.Now);
				cmd.Parameters.AddWithValue("@status", cliente.Status);
				cmd.Parameters.AddWithValue("@saldo", cliente.Saldo);

				// Preparação do Comando
				cmd.Prepare();

				// Execução do comando
				pes_codigo = cmd.ExecuteNonQuery();
				
			}
			catch (MySqlException err)
			{
				if (err.Code == 0)
				{
					myCon.Close();
					return "Dados de cadastrado duplicados. - " + err.Message +
						"\nCódigo do erro = " + err.Code.ToString();
				}
				else
				{
					myCon.Close();
					return "Erro na inserção da tabela CLiente.\n" +
					"Codigo do erro = " + err.Code.ToString() +
					"\nDescrição do erro = " + err.Message;
				}
			}
			myCon.Close();
			return "Conecção realizada com sucesso!";

		} catch (Exception ex)
        {
			myCon.Close();
			return "Erro de Conecxão = " + ex.Message;
        }
    }

	public string Alterar(long nCPF, Cliente cli) // Alterar os dados nas tabelas TBL_CLIENTES e TBL_PESSOA
	{
		long cpf = nCPF;
		cliente = cli;

		// Conectar e abrir o BD
		MySqlConnection myCon = Conectar(); 
		myCon.Open();

        try 
		{
			// Criar variáveis de comando
			MySqlCommand cmd = myCon.CreateCommand();
			MySqlCommand cmd2 = myCon.CreateCommand();

			// Declarações de comando
			cmd.CommandText = "UPDATE TBL_PESSOA SET PES_NOME=@nome, PES_EMAIL=@email WHERE PES_CPF = @cpf;";
			cmd2.CommandText = "UPDATE TBL_CLIENTE SET CLI_STATUS=@status, " +
                "CLI_SENHA=@senha, CLI_DATAHORACADASTRO = @datahoracadastro WHERE " +
                "CLI_CODIGOPES = (SELECT PES_CODIGO FROM TBL_PESSOA WHERE(PES_CPF=@cpf));";
			
			

			//Inserções de valores
			cmd.Parameters.AddWithValue("@nome", cliente.cliente.Nome);
			cmd.Parameters.AddWithValue("@cpf", cpf);
			cmd2.Parameters.AddWithValue("@cpf", cpf);
			cmd.Parameters.AddWithValue("@email", cliente.cliente.Email);
			cmd2.Parameters.AddWithValue("@senha", cliente.Senha);
			cmd2.Parameters.AddWithValue("@status", "Inativo");
			cmd2.Parameters.AddWithValue("@datahoracadastro", DateTime.Now);

			// Preparação do Comando
			cmd.Prepare();
			cmd2.Prepare();

			// Execução do comando
			cmd.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
		}
		catch (Exception ex)
        {
			myCon.Close();
			return "Falha na conexão com o Banco de Dados!\n" + ex.Message;
        }
		// Final da alteração
		myCon.Close();
		return "Alteração executada com sucesso!";
	}

	public string Excluir(long nCPF) // Alterar os dados nas tabelas TBL_CLIENTES e TBL_PESSOA
	{
		long cpf = nCPF;

		// Conectar e abrir o BD
		MySqlConnection myCon = Conectar();
		myCon.Open();

		try
		{
			// Criar variáveis de comando
			MySqlCommand cmd = myCon.CreateCommand();
			MySqlCommand cmd2 = myCon.CreateCommand();

			// Declarações de comando
			cmd.CommandText = "DELETE FROM TBL_PESSOA WHERE PES_CPF = @cpf;";
			cmd2.CommandText = "DELETE FROM TBL_CLIENTE WHERE " +
				"CLI_CODIGOPES = (SELECT PES_CODIGO FROM TBL_PESSOA WHERE(PES_CPF=@cpf));";

			cmd.Parameters.AddWithValue("@cpf", cpf);
			cmd2.Parameters.AddWithValue("@cpf", cpf);

			// Preparação do Comando
			cmd.Prepare();
			cmd2.Prepare();

			// Execução do comando
			cmd2.ExecuteNonQuery();
			cmd.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			myCon.Close();
			return "Falha na conexão com o Banco de Dados!\n" + ex.Message;
		}
		// Final da alteração
		myCon.Close();
		return "Exclusão executada com sucesso!";
	}
}
