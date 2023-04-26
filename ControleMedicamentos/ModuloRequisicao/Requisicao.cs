using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFuncionario;
using ControleMedicamentos.ModuloMedicamento;
using ControleMedicamentos.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloRequisicao
{
    public class Requisicao : EntidadeBase
    {
        public string titulo;
        public Funcionario funcionario;
        public Paciente paciente;
        public Medicamento medicamento;
        public int quantidade;

        public Requisicao(string titulo, Funcionario funcionario, Paciente paciente, Medicamento medicamento, int quantidade)
        {
            this.titulo = titulo;
            this.funcionario = funcionario;
            this.paciente = paciente;
            this.medicamento = medicamento;
            this.quantidade = quantidade;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Requisicao requisicaoAtualizado = (Requisicao)registroAtualizado;
            
            this.titulo = requisicaoAtualizado.titulo;
            this.funcionario = requisicaoAtualizado.funcionario;
            this.paciente = requisicaoAtualizado.paciente;
            this.medicamento = requisicaoAtualizado.medicamento;
            this.quantidade = requisicaoAtualizado.quantidade;

        }
    }
}
