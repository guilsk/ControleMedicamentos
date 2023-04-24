using ControleMedicamentos.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    internal class TelaMedicamento
    {
        RepositorioFornecedor repositorioFornecedor;
        TelaFornecedor telaFornecedor;
        RepositorioMedicamento repositorioMedicamento;

        public TelaMedicamento(RepositorioFornecedor repositorioFornecedor, TelaFornecedor telaFornecedor, RepositorioMedicamento repositorioMedicamento)
        {
            this.repositorioFornecedor = repositorioFornecedor;
            this.telaFornecedor = telaFornecedor;
            this.repositorioMedicamento = repositorioMedicamento;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Visualizar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Remover");
            Console.WriteLine("\nSelecione a operação: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x != 0 && x != 1 && x != 2 && x != 3 && x != 4)
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
            else if (x == 3)
            {
                Editar();
                Console.ReadLine();
            }
            else if (x == 4)
            {
                Excluir();
                Console.ReadLine();
            }
            Menu();
        }

        public void Cadastrar()
        {
            Console.Write("Digite o nome do Medicamento: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a descrição do Medicamento: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            telaFornecedor.Visualizar();
            Console.Write("Digite o ID do fornecedor: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Fornecedor fornecedor = repositorioFornecedor.SelecionarPorId(id);
            Medicamento medicamento = new Medicamento(nome, descricao, quantidade, fornecedor);
            repositorioMedicamento.Inserir(medicamento);
            Console.WriteLine("Medicamento cadastrado com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioMedicamento.listaMedicamento.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15}", "Nome", "Descrição", "Quantidade", "Fornecedor");
                foreach (Medicamento medicamento in repositorioMedicamento.listaMedicamento)
                {
                    Console.WriteLine($"{medicamento.id,-2} | {medicamento.nome,-15} | {medicamento.descricao,-15} | {medicamento.quantidade, -15} | {medicamento.fornecedor.nome, -15}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Medicamento encontrado!");
            }
        }

        public void Editar()
        {
            Visualizar();
            Console.Write("Digite o id do Medicamento que quer editar:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do Medicamento: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a descrição do Medicamento: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            telaFornecedor.Visualizar();
            Console.Write("Digite o ID do fornecedor: ");
            int id2 = Convert.ToInt32(Console.ReadLine());

            Fornecedor fornecedor = repositorioFornecedor.SelecionarPorId(id2);
            Medicamento medicamento = new Medicamento(nome, descricao, quantidade, fornecedor);
            repositorioMedicamento.Editar(medicamento, id);
            Console.WriteLine("Medicamento editado com sucesso!");
        }

        public void Excluir()
        {
            Visualizar();
            Console.Write("Digite o id do Medicamento que quer excluir:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioMedicamento.listaMedicamento.Count >= 1)
            {
                Medicamento medicamento = repositorioMedicamento.SelecionarPorId(id);
                if (medicamento != null)
                {
                    repositorioMedicamento.Excluir(id);
                    Console.WriteLine("Medicamento excluido com sucesso!");

                }
                else
                {
                    Console.WriteLine("Nenhuma Medicamento com esse ID encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Medicamento encontrado!");
            }
        }
    }
}
