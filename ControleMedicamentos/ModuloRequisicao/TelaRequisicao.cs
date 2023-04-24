using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using ControleMedicamentos.ModuloPaciente;
using ControleMedicamentos.ModuloRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloRequisicao
{
    internal class TelaRequisicao
    {
        RepositorioRequisicao repositorioRequisicao;
        RepositorioMedicamento repositorioMedicamento;
        TelaMedicamento telaMedicamento;
        RepositorioPaciente repositorioPaciente;
        TelaPaciente telaPaciente;
        RepositorioFuncionario repositorioFuncionario;
        TelaFuncionario telaFuncionario;

        public TelaRequisicao(RepositorioRequisicao repositorioRequisicao, RepositorioMedicamento repositorioMedicamento, TelaMedicamento telaMedicamento, RepositorioPaciente repositorioPaciente, TelaPaciente telaPaciente, RepositorioFuncionario repositorioFuncionario, TelaFuncionario telaFuncionario)
        {
            this.repositorioRequisicao = repositorioRequisicao;
            this.repositorioMedicamento = repositorioMedicamento;
            this.telaMedicamento = telaMedicamento;
            this.repositorioPaciente = repositorioPaciente;
            this.telaPaciente = telaPaciente;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaFuncionario = telaFuncionario;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Visualizar Histórico");
            Console.WriteLine("\nSelecione a operação: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x != 0 && x != 1 && x != 2)
            {
                Console.WriteLine("Operação inválida!");
                Console.ReadLine();
                Menu();
            }
            if (x == 0)
            {
                return;
            }
            EscolherOperacao(x);
        }

        public void EscolherOperacao(int x)
        {
            Console.Clear();
            if (x == 1)
            {
                Cadastrar();
                Console.ReadLine();
            }
            else if (x == 2)
            {
                Visualizar();
                Console.ReadLine();
            }
            Menu();
        }

        public void Cadastrar()
        {
            Console.Write("Digite o título da requisição: ");
            string titulo = Console.ReadLine();

            telaPaciente.Visualizar();
            Console.Write("Digite o ID do paciente: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Paciente paciente = repositorioPaciente.SelecionarPorId(id);


            telaFuncionario.Visualizar();
            Console.Write("Digite o ID do Funcionário: ");
            int id3 = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario = repositorioFuncionario.SelecionarPorId(id3);
           
            telaMedicamento.Visualizar();
            Console.Write("Digite o ID do Medicamento: ");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Medicamento medicamento = repositorioMedicamento.SelecionarPorId(id2);

            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            medicamento.quantidade -= quantidade;

            Requisicao requisicao = new(titulo, funcionario, paciente, medicamento, quantidade);
            repositorioRequisicao.Inserir(requisicao);
            Console.WriteLine("Requisição concluída com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioRequisicao.historicoRequisicao.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15} | {4, -15}", "Título", "Funcionário", "Paciente", "Medicamento", "Quantidade");
                foreach (Requisicao requisicao in repositorioRequisicao.historicoRequisicao)
                {
                    Console.WriteLine($"{requisicao.id,-2} | {requisicao.titulo,-15} | {requisicao.funcionario.nome,-15} | {requisicao.paciente.nome,-15} | {requisicao.medicamento.nome,-15} | {requisicao.quantidade}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma requisicao encontrada!");
            }
        }
    }
}
