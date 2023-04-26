using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloMedicamento
{
    public class Medicamento : EntidadeBase
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public Fornecedor fornecedor;

        public Medicamento(string nome, string descricao, int quantidade, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Medicamento medicamentoAtualizado = (Medicamento)registroAtualizado;

            this.nome = medicamentoAtualizado.nome;
            this.descricao = medicamentoAtualizado.descricao;
            this.quantidade = medicamentoAtualizado.quantidade;
            this.fornecedor = medicamentoAtualizado.fornecedor;
        }
    }
}
