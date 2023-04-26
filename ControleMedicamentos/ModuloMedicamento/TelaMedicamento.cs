using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    public class TelaMedicamento : TelaBase
    {
        RepositorioFornecedor repositorioFornecedor;
        TelaFornecedor telaFornecedor;
        RepositorioMedicamento repositorioMedicamento;

        public TelaMedicamento(RepositorioFornecedor repositorioFornecedor, TelaFornecedor telaFornecedor, RepositorioMedicamento repositorioMedicamento)
        {
            this.repositorioFornecedor = repositorioFornecedor;
            this.telaFornecedor = telaFornecedor;
            this.repositorioMedicamento = repositorioMedicamento;
            this.repositorioBase = repositorioMedicamento;
            this.nomeEntidade = "Medicamentos";
        }

       
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do Medicamento: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição do Medicamento: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite a quantidade do Medicamento: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            telaFornecedor.VisualizarRegistros(false);
            Console.Write("Digite o ID do fornecedor: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Fornecedor fornecedor = repositorioFornecedor.SelecionarPorId(id);

            Medicamento medicamento = new Medicamento(nome, descricao, quantidade, fornecedor);

            return medicamento;
        }

        protected override void MostrarTabela(ArrayList medicamentos)
        {
            Console.WriteLine("ID | {0, -15} | {1, -15} | {2, -15} | {3, -15}", "Nome", "Descrição", "Quantidade", "Fornecedor");
            foreach (Medicamento medicamento in medicamentos)
            {
                Console.WriteLine($"{medicamento.id,-2} | {medicamento.nome,-15} | {medicamento.descricao,-15} | {medicamento.quantidade, -15} | {medicamento.fornecedor.nome, -15}");
            }
        }

    }
}
