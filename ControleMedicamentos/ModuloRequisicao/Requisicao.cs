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
    internal class Requisicao
    {
        public string titulo;
        public Funcionario funcionario;
        public Paciente paciente;
        public Medicamento medicamento;
        public int quantidade;
        public int id;

        public Requisicao(string titulo, Funcionario funcionario, Paciente paciente, Medicamento medicamento, int quantidade)
        {
            this.titulo = titulo;
            this.funcionario = funcionario;
            this.paciente = paciente;
            this.medicamento = medicamento;
            this.quantidade = quantidade;
        }
    }
}
