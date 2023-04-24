using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFornecedor
{
    internal class TelaFornecedor
    {
        RepositorioFornecedor repositorioFornecedor;

        public TelaFornecedor(RepositorioFornecedor repositorioFornecedor)
        {
            this.repositorioFornecedor = repositorioFornecedor;
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
            Console.Write("Digite o nome do Fornecedor:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Fornecedor:");
            string telefone = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nome, telefone);
            repositorioFornecedor.Inserir(fornecedor);
            Console.WriteLine("Fornecedor cadastrado com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioFornecedor.listaFornecedor.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
                foreach (Fornecedor fornecedor in repositorioFornecedor.listaFornecedor)
                {
                    Console.WriteLine($"{fornecedor.id,-2} | {fornecedor.nome,-15} | {fornecedor.telefone,-15}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Fornecedor encontrado!");
            }
        }

        public void Editar()
        {
            Visualizar();
            Console.Write("Digite o id do Fornecedor que quer editar:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do Fornecedor:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Fornecedor:");
            string telefone = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nome, telefone);
            repositorioFornecedor.Editar(fornecedor, id);
            Console.WriteLine("Fornecedor editado com sucesso!");
        }

        public void Excluir()
        {
            Visualizar();
            Console.Write("Digite o id do Fornecedor que quer excluir:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioFornecedor.listaFornecedor.Count >= 1)
            {
                Fornecedor fornecedor = repositorioFornecedor.SelecionarPorId(id);
                if (fornecedor != null)
                {
                    repositorioFornecedor.Excluir(id);
                    Console.WriteLine("Fornecedor excluido com sucesso!");

                }
                else
                {
                    Console.WriteLine("Nenhuma Fornecedor com esse ID encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Fornecedor encontrado!");
            }
        }
    }

}
