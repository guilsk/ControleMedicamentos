using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloReposicao
{
    internal class TelaReposicao
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
            telaMedicamento.Visualizar();
            Console.Write("Digite o ID do medicamento: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Medicamento medicamento = repositorioMedicamento.SelecionarPorId(id);

            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            medicamento.quantidade += quantidade;
            
            telaFuncionario.Visualizar();
            Console.Write("Digite o ID do funcionário: ");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario = repositorioFuncionario.SelecionarPorId(id2);

            Reposicao reposicao = new(medicamento, quantidade, funcionario);
            repositorioReposicao.Inserir(reposicao);
            Console.WriteLine("Reposição concluída com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioReposicao.historicoReposicao.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15}", "Medicamento", "Quantidade", "Funcionário", "Fornecedor");
                foreach (Reposicao reposicao in repositorioReposicao.historicoReposicao)
                {
                    Console.WriteLine($"{reposicao.id,-2} | {reposicao.medicamento.nome,-15} | {reposicao.quantidade,-15} | {reposicao.funcionario.nome,-15} | {reposicao.medicamento.fornecedor.nome,-15}");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma reposição encontrada!");
            }
        }


    }
}
