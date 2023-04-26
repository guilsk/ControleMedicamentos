using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using ControleMedicamentos.ModuloPaciente;
using ControleMedicamentos.ModuloRequisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloRequisicao
{
    public class TelaRequisicao : TelaBase
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
            this.repositorioBase = repositorioRequisicao;
            this.nomeEntidade = "Requisição";
        }
        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {nomeEntidade}s \n");

            Console.WriteLine($"1 - Inserir {nomeEntidade}");
            Console.WriteLine($"2 - Visualizar Requisições");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o título da requisição: ");
            string titulo = Console.ReadLine();

            telaPaciente.VisualizarRegistros(false);
            Console.Write("Digite o ID do paciente: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Paciente paciente = repositorioPaciente.SelecionarPorId(id);


            telaFuncionario.VisualizarRegistros(false);
            Console.Write("Digite o ID do Funcionário: ");
            id = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario = repositorioFuncionario.SelecionarPorId(id);
           
            telaMedicamento.VisualizarRegistros(false);
            Console.Write("Digite o ID do Medicamento: ");
            id = Convert.ToInt32(Console.ReadLine());
            Medicamento medicamento = repositorioMedicamento.SelecionarPorId(id);

            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            medicamento.quantidade -= quantidade;

            Requisicao requisicao = new(titulo, funcionario, paciente, medicamento, quantidade);

            return requisicao;
        }

        protected override void MostrarTabela(ArrayList requisicoes)
        {
            Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15} | {4, -15}", "Título", "Funcionário", "Paciente", "Medicamento", "Quantidade");
            foreach (Requisicao requisicao in requisicoes)
            {
                Console.WriteLine($"{requisicao.id,-2} | {requisicao.titulo,-15} | {requisicao.funcionario.nome,-15} | {requisicao.paciente.nome,-15} | {requisicao.medicamento.nome,-15} | {requisicao.quantidade}");
            }
        }
    }
}
