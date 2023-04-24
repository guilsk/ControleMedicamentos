using ControleMedicamentos.ModuloFornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    internal class Medicamento
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public Fornecedor fornecedor;
        public int id;

        public Medicamento()
        {
        }

        public Medicamento(string nome, string descricao, int quantidade, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.fornecedor = fornecedor;
        }
    }
}
