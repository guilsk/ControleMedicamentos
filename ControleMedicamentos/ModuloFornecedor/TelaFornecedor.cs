using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFornecedor
{
    public class TelaFornecedor : TelaBase
    {
        RepositorioFornecedor repositorioFornecedor;

        public TelaFornecedor(RepositorioFornecedor repositorioFornecedor)
        {
            this.repositorioFornecedor = repositorioFornecedor;
            this.repositorioBase = repositorioFornecedor;
            this.nomeEntidade = "Fornecedor";
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone:");
            string telefone = Console.ReadLine();

            Fornecedor fornecedor = new(nome, telefone);

            return fornecedor;
        }

        protected override void MostrarTabela(ArrayList fornecedores)
        {
            Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
            Console.WriteLine("---------------------------------------------------------");

            foreach (Fornecedor fornecedor in fornecedores)
            {
                Console.WriteLine("{0,-2} | {1,-15} | {2,-15}", fornecedor.id, fornecedor.nome, fornecedor.telefone);
            }
        }
    }

}
