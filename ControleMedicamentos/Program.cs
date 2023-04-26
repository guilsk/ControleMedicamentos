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
            string y;
            if (x == "1")
            {
                y = telaFuncionario.ApresentarMenu();
                if(y == "1") telaFuncionario.InserirNovoRegistro();
                else if(y == "2")
                {
                    telaFuncionario.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if(y == "3") telaFuncionario.EditarRegistro();
                else if(y == "4") telaFuncionario.ExcluirRegistro();
                return 1;
            }
            else if(x == "2")
            {
                y = telaPaciente.ApresentarMenu();
                if (y == "1") telaPaciente.InserirNovoRegistro();
                else if (y == "2")
                {
                    telaPaciente.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if (y == "3") telaPaciente.EditarRegistro();
                else if (y == "4") telaPaciente.ExcluirRegistro();
                return 1;
            }
            else if (x == "3")
            {
                y = telaFornecedor.ApresentarMenu();
                if (y == "1") telaFornecedor.InserirNovoRegistro();
                else if (y == "2")
                {
                    telaFornecedor.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if (y == "3") telaFornecedor.EditarRegistro();
                else if (y == "4") telaFornecedor.ExcluirRegistro();
                return 1;
            }
            else if (x == "4")
            {
                y = telaMedicamento.ApresentarMenu();
                if (y == "1") telaMedicamento.InserirNovoRegistro();
                else if (y == "2")
                {
                    telaMedicamento.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if (y == "3") telaMedicamento.EditarRegistro();
                else if (y == "4") telaMedicamento.ExcluirRegistro();
                return 1;
            }
            else if (x == "5")
            {
                y = telaRequisicao.ApresentarMenu();
                if (y == "1") telaRequisicao.InserirNovoRegistro();
                else if (y == "2")
                {
                    telaRequisicao.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if (y == "3") telaRequisicao.EditarRegistro();
                else if (y == "4") telaRequisicao.ExcluirRegistro();
                return 1;
            }
            else if (x == "6")
            {
                y = telaReposicao.ApresentarMenu();
                if (y == "1") telaReposicao.InserirNovoRegistro();
                else if (y == "2")
                {
                    telaReposicao.VisualizarRegistros(true);
                    Console.ReadLine();
                }
                else if (y == "3") telaReposicao.EditarRegistro();
                else if (y == "4") telaReposicao.ExcluirRegistro();
                return 1;
            }
            else return 0;

            return 1;
        }

    }
}