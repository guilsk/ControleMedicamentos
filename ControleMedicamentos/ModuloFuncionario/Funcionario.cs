using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloFuncionario
{
    internal class Funcionario
    {
        public string nome;
        public string telefone;
        public int id;

        public Funcionario()
        {
        }

        public Funcionario(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
