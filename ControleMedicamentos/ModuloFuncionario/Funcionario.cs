using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFuncionario
{
    public class Funcionario : EntidadeBase
    {
        public string nome;
        public string telefone;

        public Funcionario(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Funcionario funcionarioAtualizado = (Funcionario)registroAtualizado;

            this.nome = funcionarioAtualizado.nome;
            this.telefone = funcionarioAtualizado.telefone;
        }
    }
}
