using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFuncionario
{
    public class TelaFuncionario : TelaBase
    {
        RepositorioFuncionario repositorioFuncionario;
        public TelaFuncionario(){}

        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioBase = repositorioFuncionario;
            this.nomeEntidade = "Funcionario";
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone:");
            string telefone = Console.ReadLine();

            Funcionario funcionario = new(nome, telefone);

            return funcionario;
        }

        protected override void MostrarTabela(ArrayList funcionarios)
        {   
            Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine("{0,-2} | {1,-15} | {2,-15}", funcionario.id, funcionario.nome, funcionario.telefone);
            }
            
        }

    }
}
