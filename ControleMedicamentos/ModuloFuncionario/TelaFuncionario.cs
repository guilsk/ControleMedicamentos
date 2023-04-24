using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFuncionario
{
    internal class TelaFuncionario
    {
        RepositorioFuncionario repositorioFuncionario;
        public TelaFuncionario(){}

        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
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
            Console.Write("Digite o nome do Funcionário:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Funcionário:");
            string telefone = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, telefone);
            repositorioFuncionario.Inserir(funcionario);
            Console.WriteLine("Funcionário cadastrado com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioFuncionario.listaFuncionario.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
                foreach (Funcionario funcionario in repositorioFuncionario.listaFuncionario)
                {
                    Console.WriteLine($"{funcionario.id,-2} | {funcionario.nome,-15} | {funcionario.telefone,-15}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário encontrado!");
            }
        }

        public void Editar()
        {
            Visualizar();
            Console.Write("Digite o id do funcionário que quer editar:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do Funcionário:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Funcionário:");
            string telefone = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nome, telefone);
            repositorioFuncionario.Editar(funcionario, id);
            Console.WriteLine("Funcionário editado com sucesso!");
        }

        public void Excluir()
        {
            Visualizar();
            Console.Write("Digite o id do funcionário que quer excluir:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioFuncionario.listaFuncionario.Count >= 1)
            {
                Funcionario funcionario = repositorioFuncionario.SelecionarPorId(id);
                if (funcionario != null) { 
                    repositorioFuncionario.Excluir(id);
                    Console.WriteLine("Funcionário excluido com sucesso!");

                }else
                {
                    Console.WriteLine("Nenhuma funcionário com esse ID encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcinário encontrado!");
            }
        }

    }
}
