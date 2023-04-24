using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloPaciente
{
    internal class TelaPaciente
    {
        RepositorioPaciente repositorioPaciente;
        public TelaPaciente() { }

        public TelaPaciente(RepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
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
            Console.Write("Digite o nome do Paciente:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Paciente:");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(nome, telefone);
            repositorioPaciente.Inserir(paciente);
            Console.WriteLine("Paciente cadastrado com sucesso!");
        }

        public void Visualizar()
        {
            if (repositorioPaciente.listaPaciente.Count != 0)
            {
                Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
                foreach (Paciente paciente in repositorioPaciente.listaPaciente)
                {
                    Console.WriteLine($"{paciente.id,-2} | {paciente.nome,-15} | {paciente.telefone,-15}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Paciente encontrado!");
            }
        }

        public void Editar()
        {
            Visualizar();
            Console.Write("Digite o id do Paciente que quer editar:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do Paciente:");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Paciente:");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(nome, telefone);
            repositorioPaciente.Editar(paciente, id);
            Console.WriteLine("Paciente editado com sucesso!");
        }

        public void Excluir()
        {
            Visualizar();
            Console.Write("Digite o id do Paciente que quer excluir:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (repositorioPaciente.listaPaciente.Count >= 1)
            {
                Paciente paciente = repositorioPaciente.SelecionarPorId(id);
                if (paciente != null)
                {
                    repositorioPaciente.Excluir(id);
                    Console.WriteLine("Paciente excluido com sucesso!");

                }
                else
                {
                    Console.WriteLine("Nenhuma Paciente com esse ID encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Paciente encontrado!");
            }
        }
    }
}
