using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloReposicao
{
    public class TelaReposicao : TelaBase
    {
        RepositorioReposicao repositorioReposicao;
        RepositorioMedicamento repositorioMedicamento;
        TelaMedicamento telaMedicamento;
        RepositorioFuncionario repositorioFuncionario;
        TelaFuncionario telaFuncionario;

        public TelaReposicao(RepositorioReposicao repositorioReposicao, RepositorioMedicamento repositorioMedicamento, TelaMedicamento telaMedicamento, RepositorioFuncionario repositorioFuncionario, TelaFuncionario telaFuncionario)
        {
            this.repositorioReposicao = repositorioReposicao;
            this.repositorioMedicamento = repositorioMedicamento;
            this.telaMedicamento = telaMedicamento;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaFuncionario = telaFuncionario;
            this.repositorioBase = repositorioReposicao;
            this.nomeEntidade = "Reposiçao";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {nomeEntidade}s \n");

            Console.WriteLine($"1 - Inserir {nomeEntidade}");
            Console.WriteLine($"2 - Visualizar Reposições");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override EntidadeBase ObterRegistro()
        {
            telaMedicamento.VisualizarRegistros(false);
            Console.Write("Digite o ID do medicamento: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Medicamento medicamento = repositorioMedicamento.SelecionarPorId(id);

            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            medicamento.quantidade += quantidade;
            
            telaFuncionario.VisualizarRegistros(false);
            Console.Write("Digite o ID do funcionário: ");
            id = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario = repositorioFuncionario.SelecionarPorId(id);

            Reposicao reposicao = new(medicamento, quantidade, funcionario);

            return reposicao;
        }

        protected override void MostrarTabela(ArrayList reposicoes)
        {
            Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15}", "Medicamento", "Quantidade", "Funcionário", "Fornecedor");
            foreach (Reposicao reposicao in reposicoes)
            {
                Console.WriteLine($"{reposicao.id,-2} | {reposicao.medicamento.nome,-15} | {reposicao.quantidade,-15} | {reposicao.funcionario.nome,-15} | {reposicao.medicamento.fornecedor.nome,-15}");
            }
        }
    }
}
