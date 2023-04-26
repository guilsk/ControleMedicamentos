using ControleMedicamentos.Compartilhado;
using ControleMedicamentos.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ModuloPaciente
{
    public class TelaPaciente : TelaBase
    {
        RepositorioPaciente repositorioPaciente;
        public TelaPaciente() { }

        public TelaPaciente(RepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
            this.repositorioBase = repositorioPaciente;
            this.nomeEntidade = "Pacientes";
        }
       
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone:");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(nome, telefone);

            return paciente;
        }

        protected override void MostrarTabela(ArrayList pacientes)
        {
            Console.WriteLine("ID | {0, -15} | {1, -15}", "Nome", "Telefone");
            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine("{0, -2} | {1, -15} | {2, -15}", paciente.id, paciente.nome, paciente.telefone);
            }
        }

    }
}
