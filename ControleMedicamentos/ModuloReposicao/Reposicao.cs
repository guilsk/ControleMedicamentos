using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloReposicao
{
    public class Reposicao : EntidadeBase
    {
        public Medicamento medicamento;
        public int quantidade;
        public Funcionario funcionario;

        public Reposicao(Medicamento medicamento, int quantidade, Funcionario funcionario)
        {
            this.medicamento = medicamento;
            this.quantidade = quantidade;
            this.funcionario = funcionario;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Reposicao reposicaoAtualizado = (Reposicao)registroAtualizado;

            this.medicamento = reposicaoAtualizado.medicamento;
            this.quantidade = reposicaoAtualizado.quantidade;
            this.funcionario = reposicaoAtualizado.funcionario;
        }
    }
}
