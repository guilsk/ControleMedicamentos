using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using ControleMedicamentos.ModuloPaciente;
using ControleMedicamentos.ModuloReposicao;
using ControleMedicamentos.ModuloRequisicao;
using System.Collections;

namespace ControleMedicamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioFuncionario repositorioFuncionario= new(new ArrayList());
            TelaFuncionario telaFuncionario = new(repositorioFuncionario);

            RepositorioFornecedor repositorioFornecedor = new(new ArrayList());
            TelaFornecedor telaFornecedor = new(repositorioFornecedor);


            RepositorioPaciente repositorioPaciente = new(new ArrayList());
            TelaPaciente telaPaciente = new(repositorioPaciente);

            RepositorioMedicamento repositorioMedicamento = new(new ArrayList());
            TelaMedicamento telaMedicamento = new(repositorioFornecedor, telaFornecedor, repositorioMedicamento);

            RepositorioReposicao repositorioReposicao = new(new ArrayList());
            TelaReposicao telaReposicao = new(repositorioReposicao, repositorioMedicamento, telaMedicamento, repositorioFuncionario, telaFuncionario);

            RepositorioRequisicao repositorioRequisicao = new(new ArrayList());
            TelaRequisicao telaRequisicao = new(repositorioRequisicao, repositorioMedicamento, telaMedicamento, repositorioPaciente, telaPaciente, repositorioFuncionario, telaFuncionario);

            int x = -1;
            while (x != 0)
            {
                x = Menu(telaFuncionario, telaFornecedor, telaPaciente, telaMedicamento ,telaReposicao, telaRequisicao);
            }
            Console.WriteLine("Até mais!");
        }

        public static int Menu(TelaFuncionario telaFuncionario, TelaFornecedor telaFornecedor, TelaPaciente telaPaciente, TelaMedicamento telaMedicamento, TelaReposicao telaReposicao, TelaRequisicao telaRequisicao)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Funcionário");
            Console.WriteLine("2 - Paciente");
            Console.WriteLine("3 - Fornecedor");
            Console.WriteLine("4 - Medicamento");
            Console.WriteLine("5 - Requisição");
            Console.WriteLine("6 - Reposição");
            Console.WriteLine("Digite qualquer coisa para sair");
            Console.WriteLine("\nEscolha o que quer fazer:");
            string x = Console.ReadLine();

            if (x == "1") telaFuncionario.Menu();
            else if (x == "2") telaPaciente.Menu();
            else if (x == "3") telaFornecedor.Menu();
            else if (x == "4") telaMedicamento.Menu();
            else if (x == "5") telaRequisicao.Menu();
            else if (x == "6") telaReposicao.Menu();
            else return 0;
            return 1;
        }
    }
}