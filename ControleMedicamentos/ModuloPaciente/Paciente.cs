using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloPaciente
{
    public class Paciente : EntidadeBase
    {
        public string nome;
        public string telefone;

        public Paciente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Paciente pacienteAtualizado = (Paciente)registroAtualizado;

            this.nome = pacienteAtualizado.nome;
            this.telefone = pacienteAtualizado.telefone;
        }
    }
}
